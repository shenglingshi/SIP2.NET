using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Core.Field
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseSingleValueField<T> : BaseField<T>
    {
        public BaseSingleValueField() { }

        public BaseSingleValueField(T value) : base(value)
        {
            this._value = value;
        }
    }
}
