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
    public sealed class EndItemField : BaseField<string>
    {
        public EndItemField(string value) : base(value) { }

        public EndItemField(string id, string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._name = "EndItem";
            this._id = "BQ";
        }
    }
}
