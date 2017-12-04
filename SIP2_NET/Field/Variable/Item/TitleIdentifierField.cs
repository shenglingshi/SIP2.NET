using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class TitleIdentifierField:BaseField<string>
    {
        public TitleIdentifierField() : base() { }

        public TitleIdentifierField(string value) : base(value) { }

        public TitleIdentifierField(string id, string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isRequired = true;
            this._id = "AJ";
        }
    }
}
