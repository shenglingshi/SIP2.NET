using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class FineItemsField:BaseField<int>
    {
        public FineItemsField() : base() { }

        public FineItemsField(int value) : base(value) { }

        public FineItemsField(string id, int value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "AV";
            this._name = "FineItems";
        }
    }
}
