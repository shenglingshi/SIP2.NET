using SIP2.Core.Command;
using SIP2.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIP2.Request
{
    /// <summary>
    /// 请求命令基础抽象
    /// </summary>
    public abstract class BaseRequestCommand :BaseCommand
    {
        /// <summary>
        /// 生成校验信息
        /// </summary>
        protected virtual void Checksum()
        {
            sequence++;

            _command = _command +"AY" + sequence.ToString() + "AZ";

            //计算checksum的十进制值
            ushort sum = 0;
            foreach (var item in _command)
            {
                sum += (ushort)item;
            }
            sum = (ushort)(~sum + 1);

            _command = _command + sum.ToString("X").PadLeft(4, '0');
        }

        /// <summary>
        /// 格式化命令信息
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //开始构建
            this.Format();

            //是否需要校验
            if (IsErrorDetect)
            {
                Checksum();
            }

            _command = _command + this.TerMinator;

            return _command;
        }


    }
}
