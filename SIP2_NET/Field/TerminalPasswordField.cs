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
    public sealed class TerminalPasswordField : BaseField<string>
    {
        public  TerminalPasswordField(string value) : base(value) { }

        public TerminalPasswordField(string id,string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._name = "TerminalPassword";
            this._id = "AC";
        }
    }
}
