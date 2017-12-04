using SIP2.Core.Field;
using SIP2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class TransactionDateField : BaseField<DateTime>
    {
        public TransactionDateField() : base() { }

       public TransactionDateField(DateTime value) : base(value) { }

        public TransactionDateField(string id,DateTime value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 18;
            this._isRequired = true;
        }
    }
}
