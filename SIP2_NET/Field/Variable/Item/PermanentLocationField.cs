using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class PermanentLocationField:BaseField<string>
    {
        public PermanentLocationField() : base() { }


        public PermanentLocationField(string value) : base(value) { }

        public PermanentLocationField(string id, string value) : base(id, value) { }


        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "AQ";

        }
    }
}
