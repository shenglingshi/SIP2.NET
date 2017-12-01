using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Core.Field
{
    /// <summary>
    /// 
    /// </summary>
    public interface IField
    {
        string Split { get; }

        string Name { get; set; }

        string ID { get; }

        string Description { get; set; }

        bool IsFixed { get; set; }

        int FixedLength { get; set; }

        bool IsRequired { get; set; }

        /// <summary>
        /// 格式化值
        /// </summary>
        void Format(string value);
    }
}
