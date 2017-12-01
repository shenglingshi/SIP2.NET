using SIP2.Core.Field;
using SIP2.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIP2.Request
{
    /// <summary>
    /// Request ACS Resend, Message 97
    /// This message requests the ACS to re-transmit its last message. It is sent by the SC to the ACS when the
    /// checksum in a received message does not match the value calculated by the SC.The ACS should respond
    /// by re-transmitting its last message. This message should never include a “sequence number” field, even
    /// when error detection is enabled, but would include a “checksum” field since checksums are in use.
    /// </summary>
    public sealed partial class ResendRequestCommand : BaseRequestCommand
    {
        public ResendRequestCommand()
        {
            this._identifier = "97";
            this._isErrorDetect = false;
        }

        protected override void Format()
        {
            this.CommandFields = new List<IField>() { };
            base.Format();
        }

    }
}
