using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class OverdueItemsField:BaseField<int>
    {
        public OverdueItemsField() : base() { }

        public OverdueItemsField(int value) : base(value) { }

        public OverdueItemsField(string id, int value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._id = "AT";
            this._name = "OverdueItems";
        }
    }
}
