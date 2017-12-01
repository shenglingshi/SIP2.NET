using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class CurrencyTypeField:BaseField<string>
    {
        public CurrencyTypeField() : base() { }

        public CurrencyTypeField(string value) : base(value) { }

        public CurrencyTypeField(string id, string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 3;
            this._id = "BH";
            this._name = "CurrencyType";

        }
    }
}
