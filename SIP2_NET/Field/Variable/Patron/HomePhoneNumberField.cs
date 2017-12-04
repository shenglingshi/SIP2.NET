using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class HomePhoneNumberField:BaseField<string>
    {

        public HomePhoneNumberField() : base() { }

        public HomePhoneNumberField(string value) : base(value) { }

        public HomePhoneNumberField(string id, string value) : base(id, value) { }


        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "BF";
        }


    }
}
