using System;
using System.Collections.Generic;
using System.Text;

namespace AutoRunExe.Utils
{
    public static class DateTimeUtils
    {
        /// <summary>
        /// 计算时间差；
        /// </summary>
        /// <param name="dateBegin">开始时间</param>
        /// <param name="dateEnd">结束时间</param>
        /// <returns>时间差，单位：秒</returns>
        public static int ExecDateDiff(DateTime dateBegin, DateTime dateEnd)
        {
            TimeSpan ts1 = new TimeSpan(dateBegin.Ticks);
            TimeSpan ts2 = new TimeSpan(dateEnd.Ticks);
            TimeSpan ts3 = ts1.Subtract(ts2).Duration();
            //你想转的格式
            return ((int)ts3.TotalSeconds);
        }
    }
}
