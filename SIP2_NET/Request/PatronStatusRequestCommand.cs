using SIP2.Core;
using SIP2.Core.Command;
using SIP2.Core.Field;
using SIP2.Field;
using SIP2.Field.Fixed;
using SIP2.Field.Variable;
using SIP2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIP2.Request
{
    /// <summary>
    /// Patron Status Request, Message 23
    /// 
    /// </summary>
    public sealed partial class PatronStatusRequestCommand : BaseTerminalPatronCommand
    {
        /// <summary>
        /// 语言 3字节
        /// 001 英语
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="identifier">Patron标识</param>
        public PatronStatusRequestCommand(string patronidentifier)
            :this(patronidentifier,string.Empty,string.Empty)
        {
        }

        /// <summary>
        /// 传递Patron标识和Patron密码构造函数
        /// </summary>
        /// <param name="identifier">Patron标识</param>
        /// <param name="password">Patron密码</param>
        public PatronStatusRequestCommand(string patronidentifier, string patronpassword)
            :this(patronidentifier,patronpassword,string.Empty)
        {
        }

        /// <summary>
        /// 传递Patron标识和Patron密码和终端密码构造函数
        /// </summary>
        /// <param name="patronidentifier">Patron标识</param>
        /// <param name="patronpassword">Patron密码</param>
        /// <param name="terminalPassword">终端密码</param>
        public PatronStatusRequestCommand(string patronidentifier, string patronpassword,string terminalPassword)
            :this(patronidentifier, patronpassword,terminalPassword,"001")
        {
        }

        /// <summary>
        /// 传递Patron标识和Patron密码和终端密码和语言构造函数
        /// </summary>
        /// <param name="patronidentifier"></param>
        /// <param name="patronpassword"></param>
        /// <param name="terminalPassword"></param>
        /// <param name="language">语言</param>
        public PatronStatusRequestCommand(string patronidentifier, string patronpassword, string terminalPassword,string language)
            :this(patronidentifier, patronpassword,terminalPassword,language,string.Empty)
        {            
        }

        /// <summary>
        /// 传递Patron标识和Patron密码和终端密码和语言和机构ID构造函数
        /// </summary>
        /// <param name="patronidentifier"></param>
        /// <param name="patronpassword"></param>
        /// <param name="terminalPassword"></param>
        /// <param name="language"></param>
        /// <param name="institutionId"></param>
        public PatronStatusRequestCommand(string patronidentifier, string patronpassword, string terminalPassword, string language,string institutionId)
        {
            this._identifier = "23";

            this.PatronIdentifier = patronidentifier;
            this.PatronPassword = patronpassword;
            this.TerminalPassword = terminalPassword;
            this.Language = language;
            this.InstitutionId = institutionId;
        }

        protected override void Format()
        {
            this.CommandFields = new List<IField>() {
                new LanguageField(this.Language),
                new TransactionDateField(DateTime.Now),
                new InstitutionIdField(this.InstitutionId),
                new PatronIdentifierField(this.PatronIdentifier),
                new TerminalPasswordField(this.TerminalPassword),
                new PatronPasswordField(this.PatronPassword)
            };

            base.Format();
        }

    }
}
