using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Response
{
    public abstract  class BasePatronResponseCommand:BaseResponseCommand
    {

        public BasePatronResponseCommand(string command) : base(command) { }


        public string InstitudionID { get; set; }

        public string PatronIdentifier { get; set; }

    }
}
