using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class RetriesAllowedField:BaseField<int>
    {
        public RetriesAllowedField() : base() { }

        public RetriesAllowedField(int value) : base(value) { }

        public RetriesAllowedField(string id, int value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 3;
            this._isRequired = true;
        }
    }
}
