using SIP2.Core.Field;
using SIP2.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIP2.Core.Command
{
    public interface ICommand
    {
        /// <summary>
        /// 命令标识
        /// </summary>
        string Identifier { get; }

        /// <summary>
        /// 命令结束
        /// </summary>
        string TerMinator { get; }

        /// <summary>
        /// 是否生成校验
        /// </summary>
        bool IsErrorDetect { get;}

        /// <summary>
        /// 生成的发送命令
        /// </summary>
        string Command { get;}

        /// <summary>
        /// 命令列表
        /// </summary>
        IList<IField> CommandFields { get; set; }
    }
}
