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
    public sealed class BlockedCardMsgField : BaseField<string>
    {
        public BlockedCardMsgField(string value) : base(value)
        {
        }

        public BlockedCardMsgField(string id,string value) : base(id, value)
        {
        }
    }
}
