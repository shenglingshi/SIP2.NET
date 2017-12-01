using SIP2.Core.Command;
using SIP2.Core.Field;
using SIP2.Field;
using SIP2.Field.Fixed;
using SIP2.Field.Variable;
using SIP2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIP2.Request
{
    /// <summary>
    /// Item Information, Message 17
    /// This message may be used to request item information. 
    /// The ACS should respond with the Item Information Response message.
    /// 查询书籍信息
    /// </summary>
    public sealed partial class ItemInfoRequestCommand : BaseTerminalItemCommand
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="itemIdentifier"></param>
        public ItemInfoRequestCommand(string itemIdentifier)
        {
            this._identifier = "17";

            this.ItemIdentifier = itemIdentifier;
        }

        protected override void Format()
        {
            this.CommandFields = new List<IField>()
            {
                new TransactionDateField(DateTime.Now),
                new InstitutionIdField(this.InstitutionId),
                new ItemIdentifierField(this.ItemIdentifier),
                new TerminalPasswordField(this.TerminalPassword)
            };

            base.Format();
        }
    }
}
