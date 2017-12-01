using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using SIP2.Core.Field;

namespace SIP2.Field
{
    /// <summary>
    /// 读者密码字段
    /// </summary>
    public sealed class PatronPasswordField : BaseField<string>
    {
        public PatronPasswordField(string value) : base(value) { }

        public PatronPasswordField(string id,string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._id = "AD";
            this._name = "PatronPassword";
        }
    }
}
