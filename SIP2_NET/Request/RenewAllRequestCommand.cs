using SIP2.Core.Command;
using SIP2.Core.Field;
using SIP2.Field;
using SIP2.Field.Fixed;
using SIP2.Field.Variable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIP2.Request
{
    /// <summary>
    /// Renew all ,Message 65
    /// This message is used to renew all items that the patron has checked out.
    /// The ACS should respond with a renew all response message
    /// </summary>
    public sealed partial class RenewAllRequestCommand : BaseTerminalPatronCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public bool FeeAcknowledged { get; set; }

        public RenewAllRequestCommand():this(false)
        {

        }

        public RenewAllRequestCommand(bool feeAcknowledged)
        {
            this._identifier = "65";

            this.FeeAcknowledged = feeAcknowledged;
        }

        protected override void Format()
        {
            this.CommandFields = new List<IField>() {
                new TransactionDateField(DateTime.Now),
                new InstitutionIdField(this.InstitutionId),
                new PatronIdentifierField(this.PatronIdentifier),
                new PatronPasswordField(this.PatronPassword),
                new TerminalPasswordField(this.TerminalPassword),
                new FeeAcknowledgedField(this.FeeAcknowledged)
            };

            base.Format();
        }
    }
}
