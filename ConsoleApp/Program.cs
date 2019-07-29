using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            XSSFWorkbook wb = new XSSFWorkbook();
            var st = wb.CreateSheet("emp");
            var rC = st.CreateRow(0);
            rC.CreateCell(0).SetCellValue("id");
            rC.CreateCell(1).SetCellValue("姓名");
            
            var c1 = st.CreateRow(1);
            c1.CreateCell(0).SetCellValue(222);
            c1.CreateCell(1).SetCellValue("whj");




            FileStream file = new FileStream(@"d:\test.xlsx", FileMode.Create);
            wb.Write(file);


        }
    }
}
