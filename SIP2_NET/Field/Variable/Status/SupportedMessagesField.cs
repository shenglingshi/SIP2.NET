using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class SupportedMessagesField:BaseField<string>
    {
        public SupportedMessagesField() : base() { }

        public SupportedMessagesField(string value) : base(value) { }

        public SupportedMessagesField(string id, string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "BX";
            this._isRequired = true;
        }
    }
}
