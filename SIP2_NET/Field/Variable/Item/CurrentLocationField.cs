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
    public sealed class CurrentLocationField : BaseField<string>
    {
        public CurrentLocationField() : base() { }

        public CurrentLocationField(string value) : base(value) { }

        public CurrentLocationField(string id, string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._id = "AP";
        }
    }
}
