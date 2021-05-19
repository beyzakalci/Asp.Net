using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginWeb.Models
{
    public class userClass
    {
        public string username { get; set; }
        public string userpassword { get; set; }
        public int id { get; set; }

        public userClass(string username, string userpassword)
        {
            this.username = username;
            this.userpassword = userpassword;
            this.id = id;

        }
    }
}

    
    