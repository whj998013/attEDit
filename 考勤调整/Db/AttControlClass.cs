using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CheckDb;
using 考勤调整.Util;

namespace 考勤调整
{
    public class AttControlClass
    {

        public List<HOLIDAYS> holidays;

        public attContent Con { get; set; }
        public AttControlClass(attContent con)
        {
            holidays = con.HOLIDAYS.ToList();
            Con = con;
        }
        public DayType GetDayType(DateTime d)
        {
            d = d.Date;
            var daytype = DayType.平日;
            if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday) daytype = DayType.休息日;
            var obj = holidays.Where(p => p.STARTTIME == d).FirstOrDefault();
            if (obj != null)
            {
                if (obj.HOLIDAYNAME == "法定") daytype = DayType.假日;
                else if (obj.HOLIDAYNAME == "休息日") daytype = DayType.休息日;
            }
            return daytype;
        }

        public void UpDateEmpNoteInfo(int userid, EmpNoteInfo eni)
        {
            eni.ConName = Con.ConName;

            var u = Con.USERINFO.SingleOrDefault(p => p.USERID == userid);
            if (u != null)
            {
                var noteList = ByteToListEmpNote(u.Notes);
                var e = noteList.SingleOrDefault(p => p.ConName == eni.ConName);
                if (e != null) noteList.Remove(e);
                noteList.Add(eni);
                u.Notes = ListEmpNodeToByte(noteList);
                Con.SaveChanges();
            }
        }


        public EmpNoteInfo GetEmpNoteInfoByByte(byte[] notes)
        {
            if (notes != null)
            {
                var noteList = ByteToListEmpNote(notes);
                if (noteList.Count > 0)
                {
                    var obj = noteList.SingleOrDefault(p => p.ConName == Con.ConName);
                    if (obj != null)
                    {
                        obj.Shifts.ForEach(p =>
                        {
                            p.ShiftName = "*" + p.ShiftName;
                        });
                        return obj;
                    }
                }
            }

            return null;

        }

        private List<EmpNoteInfo> ByteToListEmpNote(byte[] notes)
        {
            try
            {
                string jsonStr = Encoding.Default.GetString(notes);
                var listnote = JsonHelper.JsonToList<EmpNoteInfo>(jsonStr);
                return listnote;
            }
            catch
            {
                return new List<EmpNoteInfo>();
            }

        }

        /// <summary>
        /// 将类转换为二进制
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private byte[] ListEmpNodeToByte(object obj)
        {
            var str = JsonHelper.ToJson(obj);
            return Encoding.Default.GetBytes(str);
        }

    }
}
