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
    public sealed partial class PatronStatusResponseCommand:BaseResponseCommand
    {
        public string PatronStatus { get; set; }

        public string Language { get; set; }

        public DateTime TransactionDate { get; set; }

        public string InstitutionId { get; set; }


        public string PatronIdentifier { get; set; }

        public string PersonalName { get; set; }


        public bool ValidPatron { get; set; }

        public bool ValidPatronPassword { get; set; }


        public string CurrencyType { get; set; }


        public int FeeAmount { get; set; }


        public string ScreenMessage { get; set; }

        public string PrintLine { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="command"></param>
        public PatronStatusResponseCommand(string command) : base(command)
        {
            this.CommandFields = new List<IField>() {
                new PatronStatusField(),
                new LanguageField(),
                new TransactionDateField(),
                new InstitutionIdField() { IsRequired=true },
                new PatronIdentifierField(),
                new PersonalNameField(),
                new ValidPatronField(),
                new ValidPatronPasswordField(),
                new CurrencyTypeField(),
                new FeeAmountField(),
                new ScreenMessageField(),
                new PrintLineField()
            };
        }

    }
}
