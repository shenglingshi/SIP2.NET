using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class PersonalNameField:BaseField<string>
    {

        public PersonalNameField():base() { }

        public PersonalNameField(string value) : base(value) { }

        public PersonalNameField(string id,string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._id = "AE";
            this._isRequired = true;
        }
    }
}
