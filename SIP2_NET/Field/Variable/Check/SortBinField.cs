using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class SortBinField:BaseField<string>
    {
        public SortBinField() : base() { }

        public SortBinField(string value) : base(value) { }

        public SortBinField(string id, string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "CL";
        }
    }
}
