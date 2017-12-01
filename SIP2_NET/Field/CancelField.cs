using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field
{
    public sealed class CancelField : BaseField<bool>
    {
        public CancelField(bool value):base(value)
        {
        }

        public CancelField(string id,bool value) : base(id,value)
        {
        }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "BI";
            this._name = "Cancel";
        }
    }
}
