using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class RecallDateField:BaseField<DateTime>
    {
        public RecallDateField() : base() { }

        public RecallDateField(DateTime value) : base(value) { }

        public RecallDateField(string id, DateTime value) : base(id, value) { }


        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 18;
            this._id = "CJ";
        }
    }
}
