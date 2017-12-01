using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class HoldItemsLimitField:BaseField<int>
    {
        public HoldItemsLimitField() : base() { }

        public HoldItemsLimitField(int value) : base(value) { }

        public HoldItemsLimitField(string id, int value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 4;
            this._id = "BZ";
            this._name = "HoldItemsLimit";
        }
    }
}
