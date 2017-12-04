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
    public sealed class ItemPropertiesField : BaseField<string>
    {

        public ItemPropertiesField() : base() { }

        public ItemPropertiesField(string value) : base(value) { }

        public ItemPropertiesField(string id,string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._id = "CH";
        }
    }
}
