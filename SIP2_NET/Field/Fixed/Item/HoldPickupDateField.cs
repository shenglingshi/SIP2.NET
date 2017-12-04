using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class HoldPickupDateField:BaseField<DateTime>
    {
        public HoldPickupDateField() : base() { }

        public HoldPickupDateField(DateTime value) : base(value) { }

        public HoldPickupDateField(string id, DateTime value) : base(id, value) { }


        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 18;
            this._id = "CM";
        }
    }
}
