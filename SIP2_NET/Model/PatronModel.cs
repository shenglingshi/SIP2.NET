using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Model
{
    /// <summary>
    /// 读者信息
    /// </summary>
    public partial class PatronModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Fines { get; set; }
        public decimal FineLimit { get; set; }
        public string Message { get; set; }
        public int HoldItemLimit { get; set; }
        public string Pin { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Authorized { get; set; }
    }
}
