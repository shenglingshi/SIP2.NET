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
    public sealed class SingleStringValueField : BaseSingleValueField<string>
    {
        public SingleStringValueField() : base(){ }
        public SingleStringValueField(string value) : base(value)
        {
        }
    }
}
