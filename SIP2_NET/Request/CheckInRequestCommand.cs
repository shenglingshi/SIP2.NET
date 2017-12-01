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
    /// Checkin, Message 09
    /// This command message is initiated by the 3M SelfCheck system when it is requesting to checkin materials.
    /// It may also send this command when an item substitution is detected or item removal prior to desensitization
    /// occurs during a checkout transaction. This command will then check the item back into the library ACS.
    /// 还书
    /// </summary>
    public sealed partial class CheckInRequestCommand : BaseTerminalItemCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public bool NoBlock { get; set; }

        /// <summary>
        /// AP
        /// </summary>
        public string CurrentLocation { get; set; }

        /// <summary>
        /// BI
        /// This field is set to N when a normal checkin of materials is being requested.
        /// This field should be set to Y when a previous Checkout message failed.
        /// It is possible for a Checkout command to fail.This problem occurs when a patron removes
        /// the item from the 3M SelfCheck system cradle after it has been checked out by the ACS
        /// software but before the item has been desensitized by the 3M SelfCheck system.If thishappens,
        /// the 3M SelfCheck system would cancel the Checkout by sending a Checkin
        /// message with the cancel field set to Y. The ACS software can also use this field process the
        /// checkin differently (for example, don’t count it in the Checkin statistics, and possibly decrement the Checkout statistics, also)。
        /// If the cancel field is not being used, the ACS must keep track of the previous messages from
        /// the SC to determine if the Checkin message is being used to checkin an item or to cancel a failed Checkout        
        /// </summary>
        public bool Cancel { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="itemIdentifier">图书编码</param>
        public CheckInRequestCommand(string itemIdentifier)
            :this(itemIdentifier,false)
        {
        }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="itemIdentifier">图书编码</param>
        /// <param name="cancel">是否是取消</param>
        public CheckInRequestCommand(string itemIdentifier,bool cancel)
        {
            this._identifier = "09";

            this.ItemIdentifier = itemIdentifier;
            this.Cancel = cancel;


        }

        protected override void Format()
        {
            //命令序列
            this.CommandFields = new List<IField>() {
                    new SingleBoolValueField(this.NoBlock),
                    new TransactionDateField(DateTime.Now),
                    new TransactionDateField(DateTime.Now),
                    new CurrentLocationField(this.CurrentLocation),
                    new InstitutionIdField(this.InstitutionId),
                    new ItemIdentifierField(this.ItemIdentifier),
                    new TerminalPasswordField(this.TerminalPassword),
                    new CancelField(this.Cancel)
            };

            base.Format();
        }

    }
}
