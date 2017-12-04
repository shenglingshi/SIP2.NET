using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field
{
    public sealed class CardRetainedField : BaseSingleValueField<bool>
    {
        public CardRetainedField(bool value) : base(value)
        {
        }
    }
}
