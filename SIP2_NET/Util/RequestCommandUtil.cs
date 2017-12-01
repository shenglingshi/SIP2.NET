using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIP2.Util
{
    /// <summary>
    /// 请求实用函数
    /// </summary>
    public static class RequestCommandUtil
    {
        /// <summary>
        /// 获取日期值
        /// </summary>
        /// <returns></returns>
        public static string GetDateString()
        {
            string year = DateTime.Now.Year.ToString("00");
            string month = DateTime.Now.Month.ToString("00");
            string day = DateTime.Now.Day.ToString("00");
            string ZZZZ = "    ";
            string hour = DateTime.Now.Hour.ToString("00");
            string minute = DateTime.Now.Minute.ToString("00");
            string second = DateTime.Now.Second.ToString("00");
            return year + month + day + ZZZZ + hour + minute + second;
        }

        /// <summary>
        /// 获取日期值
        /// </summary>
        /// <returns></returns>
        public static string GetDateString(DateTime dateValue)
        {
            string year = dateValue.Year.ToString("00");
            string month = dateValue.Month.ToString("00");
            string day = dateValue.Day.ToString("00");
            string ZZZZ = "    ";
            string hour = dateValue.Hour.ToString("00");
            string minute = dateValue.Minute.ToString("00");
            string second = dateValue.Second.ToString("00");
            return year + month + day + ZZZZ + hour + minute + second;
        }

        public static DateTime GetDate(string dateString)
        {
            return DateTime.ParseExact(dateString, "YYYYMMDD    HHMMSS",System.Globalization.CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// 获取Boolean值
        /// </summary>
        /// <param name="boolValue"></param>
        /// <returns></returns>
        public static string GetBooleanString(bool boolValue)
        {
            if (boolValue)
            {
                return "Y";
            }
            return "N";
        }



    }
}
