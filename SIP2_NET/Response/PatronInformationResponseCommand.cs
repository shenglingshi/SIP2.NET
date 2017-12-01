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
    /// <summary>
    /// 
    /// </summary>
    public sealed class PatronInformationResponseCommand : BasePatronResponseCommand
    {
        public string PatronStatus { get; set; }

        public string Language { get; set; }

        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// 已借图书数量
        /// </summary>
        public int HoldItemsCount { get; set; }

        /// <summary>
        /// 过期图书数量
        /// </summary>
        public int OverdueItemsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ChargedItemsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int FineItemsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int RecallItemsCount { get; set; }

        /// <summary>
        /// 可借数量
        /// </summary>
        public int UnavailableHoldsCount { get; set; }

        public string PersonalName { get; set; }

        public int HoldItemsLimit { get; set; }

        public int OverdueItemsLimit { get; set; }

        public int ChargedItemsLimit { get; set; }

        public bool ValidPatron { get; set; }

        public bool ValidPatronPassword { get; set; }

        public int FeeAmount { get; set; }

        public int FeeLimit { get; set; }

        public string HomeAddress { get; set; }

        public string EmailAddress { get; set; }


        public string HomePhoneNumber { get; set; }


        public PatronInformationResponseCommand(string command) : base(command) {

        }

        public override void Parse()
        {
            this.CommandFields = new List<IField>() {
                new PatronStatusField(),
                new LanguageField(),
                new TransactionDateField(),
                new HoldItemsCountField(),
                new OverdueItemsCountField(),
                new ChargedItemsCountField(),
                new FineItemsCountField(),
                new RecallItemsCountField(),
                new UnavailableHoldsCountField(),
                new InstitutionIdField(),
                new PatronIdentifierField(),
                new PersonalNameField(),
                new HoldItemsLimitField(),
                new OverdueItemsLimitField(),
                new ChargeItemsLimitFieldField(),
                new ValidPatronField(),
                new ValidPatronPasswordField(),
                new CurrencyTypeField(),
                new FeeAmountField(),
                new FeeLimitField(),
                new HoldItemsField(),
                new OverdueItemsField(),
                new ChargedItemsField(),
                new FineItemsField(),
                new RecallItemsField(),
                new UnavailableHoldsCountField(),
                new HomeAddressField(),
                new EmailAddressField(),
                new HomePhoneNumberField(),
                new ScreenMessageField()
            };

            base.Parse();
        }

    }
}
