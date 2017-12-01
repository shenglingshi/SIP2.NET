using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class HoldItemsField:BaseField<int>
    {
        public HoldItemsField() : base() { }

        public HoldItemsField(int value) : base(value) { }

        public HoldItemsField(string id, int value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "AS";
            this._name = "HoldItems";
        }
    }
}
