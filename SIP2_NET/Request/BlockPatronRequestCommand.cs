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
    /// Block Patron, Message 01
    /// The 3M SelfCheck system sends this command when requesting that the ACS block a patron’s card. 
    /// For example, if a patron is suspected of tampering with the 3M SelfCheck system or when a patron forgets to take their card, this command may be sent. 
    /// The ACS must respond with a Patron Status Response, and should invalidate the patron’s card.
    /// </summary>
    public sealed partial class BlockPatronRequestCommand : BaseTerminalPatronCommand
    {
        /// <summary>
        /// This field notifies the ACS if the patron’s library card has been retained by the 3M SelfCheck system.
        /// The ACS may ignore this field or notify the library staff that the patron’s card has been retained by the 3M SelfCheck system
        /// The 3M SelfCheck system does not physically retain a card
        /// </summary>
        public bool CardRetained { get; set; }

        /// <summary>
        /// AL
        /// </summary>
        public string BlockedCardMsg { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="blockedCardMsg"></param>
        public BlockPatronRequestCommand(string blockedCardMsg):this(true,blockedCardMsg)
        {
        }

        /// <summary>
        /// 构造函数传递
        /// </summary>
        /// <param name="cardRetained"></param>
        /// <param name="blockedCardMsg"></param>
        public BlockPatronRequestCommand(bool cardRetained,string blockedCardMsg)
        {
            this._identifier = "01";

            this.CardRetained = cardRetained;
            this.BlockedCardMsg = blockedCardMsg;
        }

        protected override void Format()
        {
            this.CommandFields = new List<IField>() {
                new CardRetainedField(this.CardRetained),
                new TransactionDateField(DateTime.Now),
                new InstitutionIdField(this.InstitutionId),
                new BlockedCardMsgField(this.BlockedCardMsg),
                new PatronIdentifierField(this.PatronIdentifier),
                new TerminalPasswordField(this.TerminalPassword)
            };
            base.Format();
        }
    }
}
