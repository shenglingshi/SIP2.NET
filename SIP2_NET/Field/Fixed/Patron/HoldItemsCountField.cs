using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class HoldItemsCountField:BaseSingleValueField<int>
    {
        public HoldItemsCountField():base() { }

        public HoldItemsCountField(int value) : base(value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this.FixedLength = 4;
        }

    }
}
