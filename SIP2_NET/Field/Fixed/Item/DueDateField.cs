using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class DueDateField:BaseField<DateTime>
    {
        public DueDateField() : base() { }

        public DueDateField(DateTime value) : base(value) { }

        public DueDateField(string id, DateTime value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "AH";
            this._isRequired = true;
        }
    }
}
