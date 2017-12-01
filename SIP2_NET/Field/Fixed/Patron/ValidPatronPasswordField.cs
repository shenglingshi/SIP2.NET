using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class ValidPatronPasswordField:BaseField<bool>
    {
        public ValidPatronPasswordField() : base() { }

        public ValidPatronPasswordField(bool value) : base(value) { }

        public ValidPatronPasswordField(string id, bool value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 1;
            this._id = "CQ";
            this._name = "ValidPatronPassword";
        }
    }
}
