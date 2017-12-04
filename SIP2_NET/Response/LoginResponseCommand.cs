using SIP2.Core.Field;
using SIP2.Field;
using SIP2.Field.Fixed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Response
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoginResponseCommand:BaseResponseCommand
    {
        public int IsOk { get; set; }

        public LoginResponseCommand() { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="command"></param>
        public LoginResponseCommand(string command):base(command)
        {
            this.CommandFields = new List<IField>() {
                new IsOkField(),
            };
        }
    }
}
