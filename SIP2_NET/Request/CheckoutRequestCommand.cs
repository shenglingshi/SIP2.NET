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
    /// Checkout, Message 11
    /// This command message is initiated by the 3M SelfCheck system when it is requesting to checkout materials.
    /// The 3M SelfCheck system may also send this command when a Checkin message fails. The ACS must
    /// respond with a Checkout Response message
    /// 借书
    /// </summary>
    public sealed partial class CheckoutRequestCommand : BaseTerminalPatronItemCommand
    {
        /// <summary>
        /// A library may chose to configure a 3M SelfCheck system’s renewal policy. This field
        /// contains a ‘Y’ if the library has configured this system to allow renewals and is set to ‘N’ if
        /// they are not to be allowed.The ACS must read this value and compare it to the overall
        /// library policy to determine if a renewal is allowed.Please refer to the Renewal Processing
        /// section of this document for more information.
        /// </summary>
        public bool RenewalPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool NoBlock { get; set; }

        /// <summary>
        /// 归还日期
        /// </summary>
        public DateTime NbDueDate { get; set; }

        /// <summary>
        /// BO
        /// </summary>
        public bool FeeAcknowledged { get; set; }

        /// <summary>
        /// BI
        /// This field is set to N when a normal checkout of materials is being requested.
        /// This field is set to Y when a previous Checkin message failed.
        /// </summary>
        public bool Cancel { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public CheckoutRequestCommand(string patronIdentifier,string itemIdentifier):this(patronIdentifier,itemIdentifier,DateTime.Now.AddMonths(1))
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public CheckoutRequestCommand(string patronIdentifier, string itemIdentifier,DateTime nbDueDate)
        {
            this._identifier = "11";


            this.PatronIdentifier = patronIdentifier;
            this.ItemIdentifier = itemIdentifier;
            this.NbDueDate = nbDueDate;
            
        }

        protected override void Format()
        {
            this.CommandFields = new List<IField>()
            {
                new SingleBoolValueField(this.RenewalPolicy),
                new SingleBoolValueField(this.NoBlock),
                new TransactionDateField(DateTime.Now),
                new NbDueDateField(this.NbDueDate),
                new InstitutionIdField(this.InstitutionId),
                new PatronIdentifierField(this.PatronIdentifier),
                new ItemIdentifierField(this.ItemIdentifier),
                new TerminalPasswordField(this.TerminalPassword),
                new PatronPasswordField(this.PatronPassword),
                new FeeAcknowledgedField(this.FeeAcknowledged),
                new CancelField(this.Cancel)
            };

            base.Format();
        }

    }
}
