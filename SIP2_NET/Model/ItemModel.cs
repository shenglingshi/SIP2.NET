using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Model
{
    /// <summary>
    /// 书籍信息
    /// </summary>
    public partial class ItemModel
    {
        public string DueDate { get; set; }
        public string Title { get; set; }
        public string ItemBarcode { get; set; }
        public string PatronId { get; set; }
        public string InstitutionId { get; set; }
        public string Message { get; set; }
        public bool SuccessfulTransaction { get; set; }
        public bool SuccessfulRenewal { get; set; }
        public bool MagneticMedia { get; set; }
        public bool Desensitize { get; set; }


    }
}
