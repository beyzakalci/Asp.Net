using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginWeb.Models
{
    public class adminClass
    {
        public string adminname { get; set; }
        public string adminpassword { get; set; }

        public adminClass(string adminname, string adminpassword)
        {
            this.adminname = adminname;
            this.adminpassword = adminpassword;

        }
    }
}
