using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class LanguageField: BaseField<string>
    {
        public LanguageField():base() { }

        public LanguageField(string value) : base(value) { }

        public LanguageField(string id,string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this.FixedLength = 3;
        }
    }
}
