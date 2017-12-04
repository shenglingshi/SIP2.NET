using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIP2.Core.Field;

namespace SIP2.Field.Fixed
{
    public sealed class IsOkField:BaseSingleValueField<int>
    {
        public IsOkField() : base() { }

        public IsOkField(int value) : base(value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 1;
        }
    }
}
