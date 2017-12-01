using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class FeeLimitField:BaseField<int>
    {
        public FeeLimitField() : base(){ }

        public FeeLimitField(int value) : base(value) { }

        public FeeLimitField(string id, int value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "CC";
            this._name = "FeeLimit";
            this._description = "the fee limit amount";
        }

    }
}
