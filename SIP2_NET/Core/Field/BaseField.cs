using SIP2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Core.Field
{
    public abstract class BaseField<T> : IField
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public BaseField()
        {
            this.DefaultField();
        }

        public BaseField(T value) : this()
        {
            this._value = value;
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public BaseField(string id, T value) : this(value)
        {
            this._id = id;
        }

        protected string _split = "|";

        public string Split
        {
            get
            {
                return this._split;
            }
        }


        protected string _name;

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        protected string _id;
        /// <summary>
        /// 标识
        /// </summary>
        public string ID
        {
            get
            {
                return this._id;
            }
        }

        protected T _value;
        /// <summary>
        /// 值
        /// </summary>
        public T Value
        {
            get
            {
                return this._value;
            }
        }

        protected string _description;
        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        protected bool _isFixed;

        public bool IsFixed
        {
            get
            {
                return this._isFixed;
            }

            set
            {
                this._isFixed = value;
            }
        }

        protected int _fixedLength;
        public int FixedLength
        {
            get
            {
                return this._fixedLength;
            }

            set
            {
                this._fixedLength = value;
            }
        }

        protected bool _isRequired;
        /// <summary>
        /// 是否是必选字段
        /// </summary>
        public bool IsRequired
        {
            get
            {
                return this._isRequired;
            }
            set
            {
                this._isRequired = true;
            }
        }

        public void Format(string value)
        {
            string valueField = value;
            if (!string.IsNullOrEmpty(this._id))
            {
                valueField.Replace(this._id, "");
            }
            //判断类型
            if (this._value.GetType() == typeof(string))
            {
                this.GetType().GetField("_value").SetValue(this, valueField);
            }
            if (this._value.GetType() == typeof(bool))
            {
                this.GetType().GetField("_value").SetValue(this, Convert.ToBoolean(valueField));
            }
            if (this._value.GetType() == typeof(int))
            {
                this.GetType().GetField("_value").SetValue(this, Convert.ToInt32(valueField));
            }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        protected virtual void DefaultField()
        {
        }

        public override string ToString()
        {
            string fieldValue = string.Empty;

            //判断类型
            if (this._value.GetType() == typeof(string))
            {
                fieldValue = this._value.ToString();
            }
            if (this._value.GetType() == typeof(bool))
            {
                fieldValue = RequestCommandUtil.GetBooleanString(Convert.ToBoolean(this._value));
            }

            //是否是固定宽度
            if (_isFixed)
            {
                if (fieldValue.Length < FixedLength)
                {
                    fieldValue = fieldValue.PadRight(FixedLength, ' ');
                }
                else
                {
                    throw new ParameterException($"fixed field value {fieldValue} length is more then fixed length {FixedLength}");
                }
            }

            return $"{this.ID ?? string.Empty}{fieldValue}{this.Split ?? string.Empty}";
        }


    }
}
