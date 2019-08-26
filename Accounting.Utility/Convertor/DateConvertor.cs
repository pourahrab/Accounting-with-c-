using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accounting.Utility.Convertor
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar PC = new PersianCalendar();
            return PC.GetYear(value) + "/" + PC.GetMonth(value).ToString("00") + "/" + PC.GetDayOfMonth(value).ToString("00");
        }

        public static DateTime ToMiladi(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, new PersianCalendar());
        }
    }
}
