using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NPOI.XSSF.UserModel;
//using NPOI.SS.UserModel;
//using System.Data;
//using System.IO;

namespace 考勤调整
{
    public class ExcelOper
    {




        public static DataTable ExcelToDataTable(string filePath, string sheetname, int HeaderRowId = 0, int BeginRowId = 1)
        {
            DataTable dt = new DataTable();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                XSSFWorkbook workbook = new XSSFWorkbook(fs);
                ISheet sheet = workbook.GetSheet(sheetname); // 只读取第一个 Sheet
                // 添加列名
                IRow headerRow = sheet.GetRow(HeaderRowId);
                for (int i = 0; i < headerRow.LastCellNum; i++)
                {
                    dt.Columns.Add(headerRow.GetCell(i)?.ToString());
                }

                // 添加数据行
                for (int i = BeginRowId; i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);
                    if (row == null) continue;

                    DataRow dataRow = dt.NewRow();
                    for (int j = 0; j < row.LastCellNum; j++)
                    {
                        try
                        {
                            dataRow[j] = row.GetCell(j)?.ToString();
                        }
                        catch { }
                    }

                    dt.Rows.Add(dataRow);
                }
            }
            return dt;
        }
    }
}
