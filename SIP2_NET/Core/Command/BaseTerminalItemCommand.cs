using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Core.Command
{
    public abstract partial class BaseTerminalItemCommand:BaseCommand
    {
        /// <summary>
        /// AO
        /// </summary>
        public string InstitutionId { get; set; }

        /// <summary>
        /// 终端密码
        /// AC
        /// </summary>
        public string TerminalPassword { get; set; }

        /// <summary>
        /// Item 标识
        /// AB
        /// </summary>
        public string ItemIdentifier { get; set; }

        /// <summary>
        /// Item 标题
        /// 
        /// </summary>
        public string TitleIdentifier { get; set; }

        /// <summary>
        /// 图书属性
        /// CH
        /// </summary>
        public string ItemProperties { get; set; }
    }
}
