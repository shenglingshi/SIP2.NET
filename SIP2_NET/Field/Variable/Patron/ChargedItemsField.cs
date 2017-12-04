using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class ChargedItemsField:BaseField<int>
    {
        public ChargedItemsField() : base() { }

        public ChargedItemsField(int value) : base(value) { }

        public ChargedItemsField(string id,int value) : base(id, value) { }


        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "AU";
        }

    }
}
