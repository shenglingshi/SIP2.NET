using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class SupportedMessageField:BaseField<string>
    {
        public SupportedMessageField() : base() { }

        public SupportedMessageField(string value) : base(value) { }

        public SupportedMessageField(string id, string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "BX";
            this._isRequired = true;
        }
    }
}
