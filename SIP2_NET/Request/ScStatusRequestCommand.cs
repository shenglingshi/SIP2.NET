using SIP2.Core;
using SIP2.Core.Field;
using SIP2.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIP2.Request
{
    /// <summary>
    /// SC Status, Message 99
    /// The SC status message sends SC status to the ACS.
    /// It requires an ACS Status Response message reply from the ACS.
    /// This message will be the first message sent by the SC to the ACS once a connection has been established.
    /// The ACS will respond with a message that establishes some of the rules to be followed by the SC and establishes some parameters needed fro furtuer communication.
    /// </summary>
    public sealed partial class ScStatusRequestCommand : BaseRequestCommand
    {
        /// <summary>
        /// 状态码 0,1,2
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// 最大打印字符数
        /// </summary>
        public int MaxPrintWidth { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public ScStatusRequestCommand():this(0,0)
        {
        }

        /// <summary>
        /// 传递参数构造函数
        /// </summary>
        /// <param name="statusCode">状态码</param>
        public ScStatusRequestCommand(int statusCode) : this(statusCode, 0)
        {
        }

        /// <summary>
        /// 传递参数构造函数
        /// </summary>
        /// <param name="statusCode">状态码</param>
        /// <param name="maxPrintWidth">最大宽度</param>
        public ScStatusRequestCommand(int statusCode, int maxPrintWidth) : this(statusCode, maxPrintWidth,2.0)
        {
        }

        /// <summary>
        /// 传递参数构造函数
        /// </summary>
        /// <param name="statusCode">状态码</param>
        /// <param name="maxPrintWidth">最大宽度</param>
        public ScStatusRequestCommand(int statusCode, int maxPrintWidth, double version)
        {
            this._identifier = "99";

            this.StatusCode = statusCode;
            this.MaxPrintWidth = maxPrintWidth;
            this.ProtocolVersion = version.ToString("F2");

        }

        /// <summary>
        /// 格式化
        /// </summary>
        protected override void Format()
        {
            this.CommandFields = new List<IField>() {
                new SingleIntValueField(this.StatusCode),
                new SingleIntValueField(this.MaxPrintWidth) { IsFixed=true,FixedLength=3 },
                new SingleStringValueField(this.ProtocolVersion)
            };
            base.Format();
        }
    }
}
