using SIP2.Core.Field;
using SIP2.Field.Fixed;
using SIP2.Field.Variable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Response
{
    public sealed partial class CheckoutResponseCommand:BaseResponseCommand
    {
        public int Ok { get; set; }

        public bool RenewalOk { get; set; }

        public bool Desensitize { get; set; }

        public char MagneticMedia { get; set; }

        public DateTime TransactionDate { get; set; }

        public string InstitutionID { get; set; }

        public string PatronIdentifier { get; set; }

        public string ItemIdentifier { get; set; }

        public string TitleIdentifier { get; set; }

        public DateTime? DueDate { get; set; }

        public string FeeType { get; set; }


        public bool SecurityInhibit { get; set; }


        public string CurrencyType { get; set; }


        public int FeeAmount { get; set; }

        public string MediaType { get; set; }


        public string ItemProperties { get; set; }


        public string TransactionId { get; set; }


        public string ScreenMessage { get; set; }

        public string PrintLine { get; set; }

        public CheckoutResponseCommand(string command) : base(command) {

            this.CommandFields = new List<IField>() {
                new OkField(),
                new RenewalOkField(),
                new MagneticMediaField(),
                new DesensitizeField(),
                new TransactionDateField(),
                new InstitutionIdField(),
                new PatronIdentifierField(),
                new ItemIdentifierField(),
                new TitleIdentifierField(),
                new DueDateField(),
                new FeeTypeField() { IsRequired=false },
                new SecurityInhibitField(),
                new CurrencyTypeField(),
                new FeeAmountField(),
                new MediaTypeField(),
                new ItemPropertiesField(),
                new TransactionIdField(),
                new ScreenMessageField(),
                new PrintLineField()
            };
        }

    }
}
