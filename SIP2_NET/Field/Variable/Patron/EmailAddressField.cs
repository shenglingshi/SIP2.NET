using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed partial class EmailAddressField:BaseField<string>
    {
        public EmailAddressField() : base() { }

        public EmailAddressField(string value) :base(value) { }


        public EmailAddressField(string id, string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "BE";
            this._name = "EmailAddress";
        }

    }
}
