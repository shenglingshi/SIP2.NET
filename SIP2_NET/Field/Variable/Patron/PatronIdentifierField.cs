using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIP2.Field.Variable
{
    /// <summary>
    /// 读者标识字段
    /// </summary>
    public sealed class PatronIdentifierField : BaseField<string>
    {
        public PatronIdentifierField() : base() { }

        public PatronIdentifierField(string value) : base(value) { }

        public PatronIdentifierField(string id,string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._name = "PatronIdentifier";
            this._id = "AA";
        }
    }
}
