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
    public abstract class BaseSignleValueField<T> : BaseField<T>
    {
        public BaseSignleValueField() { }

        public BaseSignleValueField(T value) : base(value)
        {
            this._value = value;
        }
    }
}
