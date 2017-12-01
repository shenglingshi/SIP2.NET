using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ItemIdentifierField : BaseField<string>
    {

        public ItemIdentifierField(string value) : base(value) { }

        public ItemIdentifierField(string id,string value) : base(id, value) { }


        protected override void DefaultField()
        {
            base.DefaultField();
            this._name = "ItemIdentifier";
            this._id = "AB";
        }
    }
}
