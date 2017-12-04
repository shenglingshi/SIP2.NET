using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Core.Command
{
    public abstract partial class BaseItemCommand:BaseCommand
    {
        /// <summary>
        /// Item 标识
        /// AB
        /// </summary>
        public string ItemIdentifier { get; set; }

        /// <summary>
        /// Item 标题
        /// AJ
        /// </summary>
        public string TitleIdentifier { get; set; }

        /// <summary>
        /// BG
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// BH
        /// </summary>
        public string CurrencyType { get; set; }

        /// <summary>
        /// BV
        /// </summary>
        public int FeeAmount { get; set; }

        /// <summary>
        /// 3M strongly encourages the use of this field. This information allows 3M
        /// SelfCheck system to provide more meaningful messages to the patron if there is a problem.
        /// CK
        /// </summary>
        public string MediaType { get; set; }

        /// <summary>
        /// AQ
        /// </summary>
        public string PermanentLocation { get; set; }

        /// <summary>
        /// AP
        /// </summary>
        public string CurrentLocation { get; set; }

        /// <summary>
        /// 图书属性
        /// CH
        /// </summary>
        public string ItemProperties { get; set; }

    }
}
