using SIP2.Core.Field;
using SIP2.Field;
using SIP2.Field.Fixed;
using SIP2.Field.Variable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Response
{
    public sealed class AcsStatusResponseCommand : BaseResponseCommand
    {

        public bool OnlineStatus { get; set; }

        public bool CheckInOk { get; set; }

        public bool CheckoutOk { get; set; }


        public bool RenewalPolicy { get; set; }


        public bool StatusUpdateOk { get; set; }


        public bool OfflineOk { get; set; }

        public int TimeoutPeriod { get; set; }

        public int RetriesAllowed{get;set;}

        public DateTime DateTimeSync { get; set; }

        public string ProtocolVersion { get; set; }

        public string InstitutionId { get; set; }

        public string LibraryName { get; set; }

        public string SupportedMessages { get; set; }

        public string TerminalLocation { get; set; }

        public string ScreenMessage { get; set; }

        public string PrintLine { get; set; }


        public AcsStatusResponseCommand(string command):base(command)
        {
            this.CommandFields = new List<IField>() {
                new OnlineStatusField() ,
                new CheckInOkField(),
                new CheckoutOkField(),
                new RenewalPolicyField(),
                new StatusUpdateOkField(),
                new OfflineOkField(),
                new TimeoutPeriodField(),
                new RetriesAllowedField(),
                new TransactionDateField() { Name="DateTimeSync" },
                new ProtocolVersionField(),
                new InstitutionIdField(),
                new SupportedMessageField(),
                new TerminalLocationField(),
                new ScreenMessageField(),
                new PrintLineField()
            };
        }
    }
}
