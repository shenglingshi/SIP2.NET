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
    public sealed class StartItemField : BaseField<string>
    {
        public StartItemField(string value) : base(value) { }

        public StartItemField(string id,string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._name = "StartItem";
            this._id = "BP";
        }
    }
}
