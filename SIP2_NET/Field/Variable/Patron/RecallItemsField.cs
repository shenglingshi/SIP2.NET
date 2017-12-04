using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class RecallItemsField:BaseField<int>
    {
        public RecallItemsField() : base() { }

        public RecallItemsField(int value) : base(value) { }

        public RecallItemsField(string id, int value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "BU";
        }
    }
}
