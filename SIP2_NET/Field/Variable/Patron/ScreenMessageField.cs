using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class ScreenMessageField:BaseField<string>
    {
        public ScreenMessageField() : base() { }

        public ScreenMessageField(string value) : base(value) { }

        public ScreenMessageField(string id, string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "AF";
            this._name = "ScreenMessage";
        }
    }
}
