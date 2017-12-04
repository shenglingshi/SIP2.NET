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
    public sealed partial class CheckInResponseCommand:BaseResponseCommand
    {
        public int Ok { get; set; }

        public bool Resensitize { get; set; }

        public char MagneticMedia { get; set; }

        public bool Alert { get; set; }

        public DateTime TransactionDate { get; set; }

        public string InstitudionID { get; set; }

        public string ItemIdentifier { get; set; }

        public string PermanentLocation { get; set; }

        public string TitleIdentifier { get; set; }

        public string SortBin { get; set; }

        public string PatronIdentifier { get; set; }

        public string MediaType { get; set; }

        public string ItemProperties { get; set; }

        public string ScreenMessage { get; set; }

        public string PrintLine { get; set; }

        public CheckInResponseCommand(string command) : base(command)
        {
            this.CommandFields = new List<IField>() {
                new OkField(),
                new ResensitizeField(),
                new MagneticMediaField(),
                new AlertField(),
                new TransactionDateField(),
                new InstitutionIdField(),
                new ItemIdentifierField(),
                new PermanentLocationField(),
                new TitleIdentifierField(),
                new SortBinField(),
                new PatronIdentifierField(),
                new MediaTypeField(),
                new ItemPropertiesField(),
                new ScreenMessageField(),
                new PrintLineField()
            };
        }

    }
}
