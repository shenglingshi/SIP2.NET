using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class OverdueItemsLimitField:BaseField<int>
    {
        public OverdueItemsLimitField():base(){ }

        public OverdueItemsLimitField(int value) : base(value) { }

        public OverdueItemsLimitField(string id, int value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 4;
            this._id = "CA";
            this._name = "OverdueItemsLimit";
        }
    }
}
