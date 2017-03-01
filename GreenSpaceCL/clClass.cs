using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenSpaceCL
{
    public class clError
    {
        public int? id { get; set; }
        public string ErrorLog { get; set; }
        public string createDate { get; set; }
        public string Page { get; set; }

        public string IP { get; set; }

        public int? ConnectionOpen { get; set; }
        public string timeLeft { get; set; }
    }
}
