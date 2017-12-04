using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SIP2.Field.Variable
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class InstitutionIdField: BaseField<string>
    {
        public InstitutionIdField() : base() { }

        public InstitutionIdField(string value) : base(value) { }

        public InstitutionIdField(string id,string value) : base(id, value) { }

        protected override void DefaultField()
        {
            base.DefaultField();
            this._id = "AO";
        }
    }
}
