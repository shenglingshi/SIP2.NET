using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field
{
    public sealed class SingleBoolValueField : BaseSingleValueField<bool>
    {
        public SingleBoolValueField() : base() { }

        public SingleBoolValueField(bool value) : base(value)
        {

            this._isRequired = true;
            this._isFixed = true;
            this._fixedLength = 1;
        }
    }
}
