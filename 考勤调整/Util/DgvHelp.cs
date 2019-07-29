using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 考勤调整.Util
{
   public class DgvHelp
    {
        public static void PointNum(DataGridView DGV, DataGridViewRowPostPaintEventArgs e)
        {
            var color = DGV.RowHeadersDefaultCellStyle.ForeColor;
            if (DGV.Rows[e.RowIndex].Selected)
            {

                color = DGV.RowHeadersDefaultCellStyle.SelectionForeColor;
            }
            else
            {
                color = DGV.RowHeadersDefaultCellStyle.ForeColor;
            }
            var b = new SolidBrush(color);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 12, e.RowBounds.Location.Y + 6);
        }
    }
}
