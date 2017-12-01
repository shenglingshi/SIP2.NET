using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIP2.Field;
using SIP2.Core.Field;

namespace SIP2.Core.Command
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseCommand : ICommand
    {

        #region private field
        /// <summary>
        /// 命令标识
        /// </summary>
        protected string _identifier;
        /// <summary>
        /// 命令结束符
        /// </summary>
        protected string _terminator = "\r";
        /// <summary>
        /// 是否生成校验
        /// </summary>
        protected bool _isErrorDetect = true;
        /// <summary>
        /// 序列号
        /// </summary>
        protected static int sequence = 0;
        /// <summary>
        /// 生成的命令
        /// </summary>
        protected string _command;

        protected IList<IField> _commandFields;
        #endregion

        #region public property

        public string Identifier
        {
            get
            {
                return _identifier;
            }
        }

        public bool IsErrorDetect
        {
            get
            {
                return _isErrorDetect;
            }
        }

        public string TerMinator
        {
            get
            {
                return _terminator;
            }
        }

        public string Command
        {
            get
            {
                return _command;
            }
        }

        public IList<IField> CommandFields
        {
            get
            {
                return this._commandFields;
            }
            set
            {
                this._commandFields = value;
            }
        }
        #endregion

        /// <summary>
        /// 构造
        /// </summary>
        protected virtual void Format()
        {
            ///格式化字符串
            StringBuilder commandBuilder = new StringBuilder(this.Identifier);

            if (this.CommandFields != null)
            {
                foreach (var item in this.CommandFields)
                {
                    commandBuilder.Append(item.ToString());
                }
            }

            this._command = commandBuilder.ToString();
        }

        
    }
}
