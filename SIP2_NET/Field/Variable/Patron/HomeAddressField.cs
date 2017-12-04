using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Variable
{
    public sealed class HomeAddressField:BaseField<string>
    {

        protected override void DefaultField()
        {
            base.DefaultField();

            this._id = "BD";
        }

    }
}
