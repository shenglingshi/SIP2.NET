using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class ValidPatronField : BaseField<bool>
    {
        public ValidPatronField() : base() { }

        public ValidPatronField(bool value) : base(value) { }

        public ValidPatronField(string id, bool value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 1;
            this._id = "BL";
            this._name = "ValidPatron";
        }
    }
}
