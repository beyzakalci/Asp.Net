using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginWeb.Models
{
    public class systemClass
    {
        public string systemname { get; set; }
        public string systempassword { get; set; }

        public systemClass(string systemname, string systempassword)
        {
            this.systemname = systemname;
            this.systempassword = systempassword;

        }
    }
}
