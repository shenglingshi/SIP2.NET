using SIP2.Core.Field;
using SIP2.Util;
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
    public sealed class NbDueDateField : BaseField<DateTime>
    {
        public NbDueDateField(DateTime value) : base(value) { }

        public NbDueDateField(string id,DateTime value) : base(id, value) { }


        protected override void DefaultField()
        {
            base.DefaultField();
            this._name = "NbDueDate";
        }
    }
}
