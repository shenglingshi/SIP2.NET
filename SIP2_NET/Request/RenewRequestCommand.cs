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
    /// Renew,Message 97
    /// The message is used to renew an item,
    /// The ACS should respond with a Renew Response message.
    /// Either or both the "item identifier" and "title identifier" fields must be present for the message to be useful.
    /// </summary>
    public sealed partial class RenewRequestCommand : BaseTerminalPatronItemCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public bool ThirdPartyAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool NoBlock { get; set; }

        /// <summary>
        /// 归还日期
        /// </summary>
        public DateTime NbDueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool FeeAcknowledged { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="patronIdentifier"></param>
        /// <param name="itemIdentifier"></param>
        public RenewRequestCommand(string patronIdentifier,string itemIdentifier):this(patronIdentifier,itemIdentifier,DateTime.Now.AddMonths(1))
        {

        }

        public RenewRequestCommand(string patronIdentifier, string itemIdentifier,DateTime nbDueDate)
        {
            this._identifier = "29";

            this.ThirdPartyAllowed = true;
            this.PatronIdentifier = patronIdentifier;
            this.ItemIdentifier = itemIdentifier;
            this.NbDueDate = nbDueDate;
        }

        protected override void Format()
        {
            this.CommandFields = new List<IField>() {
                new SingleBoolValueField(this.ThirdPartyAllowed),
                new SingleBoolValueField(this.NoBlock),
                new TransactionDateField(DateTime.Now),
                new NbDueDateField(this.NbDueDate),
                new InstitutionIdField(this.InstitutionId),
                new PatronIdentifierField(this.PatronIdentifier),
                new PatronPasswordField(this.PatronPassword),
                new ItemIdentifierField(this.ItemIdentifier),
                new TerminalPasswordField(this.TerminalPassword),
                new ItemPropertiesField(this.ItemProperties),
                new FeeAcknowledgedField(this.FeeAcknowledged)
            };

            base.Format();
        }

    }
}
