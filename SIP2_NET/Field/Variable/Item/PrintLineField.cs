using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class PrintLineField:BaseField<string>
    {
        public PrintLineField() { }


        public PrintLineField(string value) : base(value) { }

        public PrintLineField(string id, string value) : base(id, value) { }


        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "AG";
        }
    }
}
