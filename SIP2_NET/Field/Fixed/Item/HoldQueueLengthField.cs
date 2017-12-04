using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class HoldQueueLengthField:BaseField<int>
    {
        public HoldQueueLengthField() : base() { }

        public HoldQueueLengthField(int value) : base(value) { }

        public HoldQueueLengthField(string id, int value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "CF";
        }
    }
}
