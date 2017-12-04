using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class TerminalLocationField:BaseField<string>
    {
        public TerminalLocationField() : base() { }

        public TerminalLocationField(string value) : base(value) { }

        public TerminalLocationField(string id, string value):base(id,value) { }


        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "AN";

        }

    }
}
