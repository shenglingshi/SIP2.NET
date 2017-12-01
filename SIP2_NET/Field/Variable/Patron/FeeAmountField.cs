using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class FeeAmountField:BaseField<int>
    {
        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "BV";
            this._name = "FeeAmount";
        }
    }
}
