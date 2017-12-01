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
    public sealed class FeeAcknowledgedField : BaseField<bool>
    {
        public FeeAcknowledgedField(bool value) : base(value) { }

        public FeeAcknowledgedField(string id,bool value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._name = "FeeAcknowledged";
            this._id = "BO";
        }
    }
}
