using SIP2.Core;
using SIP2.Core.Field;
using SIP2.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;

namespace SIP2.Request
{
    /// <summary>
    /// Login, Message 93
    /// This message can be used to login to an ACS server program.
    /// The ACS should respond with the Login Response message.
    /// Whether to use this message or to use some other machanism to login to the ACS is configurable on the SC.
    /// </summary>
    public sealed partial class LoginRequestCommand : BaseRequestCommand
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string LoginUserId { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string LoginPassword { get; set; }
        /// <summary>
        /// 位置代码
        /// </summary>
        public string LocationCode { get; set; }

        /// <summary>
        /// 是否对用户ID进行加密
        /// </summary>
        public int IsUserIdAlgorithm { get;}

        /// <summary>
        /// 是否对用户密码进行加密
        /// </summary>
        public int IsPasswordAlgorithm { get;}

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        public LoginRequestCommand(string userId,string password)
            :this(userId,password,string.Empty)
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <param name="location"></param>
        public LoginRequestCommand(string userId,string password,string location, int isUserIdAlgorithm =0, int isPasswordAlgorithm =0)
        {
            this._identifier = "93";


            this.LoginUserId = userId;
            this.LoginPassword = password;
            this.LocationCode = location;
            this.IsUserIdAlgorithm = isUserIdAlgorithm;
            this.IsPasswordAlgorithm = isPasswordAlgorithm;

        }

        protected override void Format()
        {
            this.CommandFields = new List<IField>() {
                new SingleIntValueField(this.IsUserIdAlgorithm),
                new SingleIntValueField(this.IsPasswordAlgorithm),
                new LoginUserIdField(this.LoginUserId),
                new LoginPasswordField(this.LoginPassword),
                new LocationCodeField(this.LocationCode)
            };

            base.Format();
        }

    }
}
