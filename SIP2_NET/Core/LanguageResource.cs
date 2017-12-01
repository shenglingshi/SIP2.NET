using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Reflection;

namespace SIP2.Core
{
    /// <summary>
    /// 语言文件
    /// </summary>
    public class LanguageResource
    {
        private static ResourceManager _resourceManager = null;

        /// <summary>
        /// 静态构造函数
        /// </summary>
        static LanguageResource()
        {
            _resourceManager = new ResourceManager("SIP2.Languages.Language", typeof(LanguageResource).Assembly) { IgnoreCase=true };
        }


        public string GetLanguageString(string key)
        {
            return _resourceManager.GetString(key);
        }


        public static class LanguageKeys
        {
            public static string UserIdIsNull = "UserIdIsNull";

            public static string UserPasswordIsNull = "UserPasswordIsNull";

            public static string ScStatus_StatusCodeIsWrong = "ScStatus_StatusCodeIsWrong";

            public static string ScStatus_MaxPrintWidthIsWrong = "ScStatus_MaxPrintWidthIsWrong";

            public static string PatronStatus_PatronIdentifierNotFound= "PatronStatus_PatronIdentifierNotFound";

            public static string PatronInformation_PatronIdentifierNotFound = "PatronInformation_PatronIdentifierNotFound";
        }


    }
}
