﻿using SIP2.Core.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Field.Fixed
{
    public sealed class SecurityInhibitField:BaseSingleValueField<bool>
    {
        public SecurityInhibitField() : base() { }

        public SecurityInhibitField(bool value) : base(value) { }

        protected override void DefaultField()
        {
            base.DefaultField();

            this._isFixed = true;
            this._fixedLength = 1;
        }
    }
}
