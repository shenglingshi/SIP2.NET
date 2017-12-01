using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class ChargedItemsCountField:BaseSignleValueField<int>
    {
        public ChargedItemsCountField() : base() { }

        public ChargedItemsCountField(int value) : base(value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 4;
            this._name = "ChargedItemsCount";
        }
    }
}
