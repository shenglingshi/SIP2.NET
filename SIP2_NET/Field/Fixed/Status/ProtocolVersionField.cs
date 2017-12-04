using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class ProtocolVersionField:BaseField<string>
    {
        public ProtocolVersionField() : base() { }

        public ProtocolVersionField(string value) : base(value) { }

        public ProtocolVersionField(string id, string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 4;
            this.IsRequired = true;
        }

    }
}
