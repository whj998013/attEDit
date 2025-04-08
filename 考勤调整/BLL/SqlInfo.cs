using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace 考勤调整
{
    public class SqlInfo
    {
        public string ServerName { get; set; }
        public string User { get; set; }
        public string PassWord { get; set; }

        public string GetSqlConnectString(string DbName)
        {
            string str = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", this.ServerName, DbName, this.User, this.PassWord);
            return str;
        }

        public string GetSqlConnectString()
        {
            string str = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", this.ServerName, "master", this.User, this.PassWord);
            return str;
        }



        /// <summary>
        /// 检查数据库是否存在
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public bool CheckDatabaseExists(string dbName)
        {
            using (SqlConnection connection = new SqlConnection(GetSqlConnectString()))
            {

                connection.Open();
                string sql = $"SELECT COUNT(*) FROM sys.databases WHERE name = '{dbName}'";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }


        /// <summary>
        /// 创建数据库并执行SQL脚本文件
        /// </summary>
        /// <param name="databaseName">要创建的新数据库名称</param>
        /// <param name="sqlScriptPath">SQL脚本文件的完整路径</param>
        /// <exception cref="ArgumentException">当参数无效时抛出</exception>
        /// <exception cref="FileNotFoundException">当SQL文件不存在时抛出</exception>
        /// <exception cref="SqlException">当SQL操作失败时抛出</exception>
        public string CreateDatabaseAndExecuteScript(string databaseName, string sqlScriptPath)
        {
            // 参数验证

            if (string.IsNullOrWhiteSpace(databaseName))
                throw new ArgumentException("数据库名称不能为空", nameof(databaseName));

            if (!File.Exists(sqlScriptPath))
                throw new FileNotFoundException("指定的SQL脚本文件不存在", sqlScriptPath);

            // 构建连接字符串
            string masterConnectionString = GetSqlConnectString();
            string targetConnectionString = GetSqlConnectString(databaseName);

            // 1. 创建数据库
            CreateDatabase(masterConnectionString, databaseName);

            // 2. 执行SQL脚本
            ExecuteSqlScript(targetConnectionString, sqlScriptPath);
            return targetConnectionString;
        }

        /// <summary>
        /// 构建SQL Server连接字符串
        /// </summary>
        /// <param name="server">服务器名称</param>
        /// <param name="database">数据库名称</param>
        /// <param name="useWindowsAuth">是否使用Windows身份验证</param>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>格式化后的连接字符串</returns>
        private static string BuildConnectionString(
            string server,
            string database,
            bool useWindowsAuth,
            string userName,
            string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = server,
                InitialCatalog = database,
                IntegratedSecurity = useWindowsAuth
            };

            if (!useWindowsAuth)
            {
                builder.UserID = userName;
                builder.Password = password;
            }

            // 添加连接池和超时设置
            builder.Pooling = true;
            builder.ConnectTimeout = 30;

            return builder.ToString();
        }

        /// <summary>
        /// 创建新数据库（如果不存在）
        /// </summary>
        /// <param name="connectionString">master数据库连接字符串</param>
        /// <param name="databaseName">要创建的数据库名称</param>
        private static void CreateDatabase(string connectionString, string databaseName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 使用参数化查询防止SQL注入
                string sql = $@"
                IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = @dbName)
                BEGIN
                    CREATE DATABASE [{databaseName}];
                    PRINT '数据库 {databaseName} 创建成功';
                END
                ELSE
                BEGIN
                    PRINT '数据库 {databaseName} 已存在';
                END";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@dbName", databaseName);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 执行SQL脚本文件
        /// </summary>
        /// <param name="connectionString">目标数据库连接字符串</param>
        /// <param name="scriptPath">SQL脚本文件路径</param>
        private static void ExecuteSqlScript(string connectionString, string scriptPath)
        {
            string scriptContent = File.ReadAllText(scriptPath);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 分割脚本（处理GO语句）
                string[] batches = scriptContent.Split(
                    new[] { "GO" },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string batch in batches)
                {
                    if (string.IsNullOrWhiteSpace(batch))
                        continue;

                    using (SqlCommand command = new SqlCommand(batch, connection))
                    {
                        command.CommandTimeout = 120; // 设置2分钟超时
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}
