using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class MediaTypeField:BaseField<string>
    {
        public MediaTypeField() : base() { }

        public MediaTypeField(string value) : base(value) { }

        public MediaTypeField(string id, string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 3;
            this._id = "CK";
        }
    }
}
