using SIP2.Core.Command;
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
    public sealed partial class ItemInformationResponseCommand : BaseItemResponseCommand
    {
        public ItemInformationResponseCommand(string command):base(command)
        {
            this.CommandFields = new List<IField>() {
                new CirculationStatusField(),
                new SecurityMarkerField(),
                new FeeTypeField(),
                new TransactionDateField(),
                new HoldQueueLengthField(),
                new DueDateField(),
                new RecallDateField(),
                new ItemIdentifierField(),
                new TitleIdentifierField(),
                new OwnerField(),
                new CurrencyTypeField(),
                new FeeAmountField(),
                new MediaTypeField(),
                new PermanentLocationField(),
                new CurrentLocationField(),
                new ItemPropertiesField(),
                new ScreenMessageField(),
                new PrintLineField()
            };
        }

        public string CirculationStatus { get; set; }

        public string SecurityMarker { get; set; }

        public string FeeType { get; set; }

        public DateTime TransactionDate { get; set; }

        public int HoldQueueLenght { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? RecallDate { get; set; }

        public DateTime? HoldPickupDate { get; set; }

        public string ScreenMessage { get; set; }

        public string PrintLine { get; set; }

    }
}
