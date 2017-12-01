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
    public sealed class LoginUserIdField : BaseField<string>
    {
        public LoginUserIdField(string value) : base(value) { }

        public LoginUserIdField(string id,string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._name = "LoginUserId";
            this._id = "CN";
        }
    }
}
