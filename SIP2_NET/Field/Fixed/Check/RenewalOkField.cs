using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class RenewalOkField:BaseSingleValueField<bool>
    {
        public RenewalOkField() { }

        public RenewalOkField(bool value) : base(value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._isFixed = true;
            this._fixedLength = 1;
            this._isRequired = true;
        }
    }
}
