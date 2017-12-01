using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Core.Command
{
    public abstract partial class BaseTerminalPatronCommand:BaseCommand
    {
        /// <summary>
        /// 机构标识
        /// AO
        /// </summary>
        public string InstitutionId { get; set; }

        /// <summary>
        /// 终端密码
        /// AC
        /// </summary>
        public string TerminalPassword { get; set; }

        /// <summary>
        /// Patron标识
        /// AA
        /// </summary>
        public string PatronIdentifier { get; set; }

        /// <summary>
        /// Patron密码
        /// AD
        /// </summary>
        public string PatronPassword { get; set; }
    }
}
