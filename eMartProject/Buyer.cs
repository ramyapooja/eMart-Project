using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMartProject
{
    class Buyer
    {
        public int b_id { get; set; }
        public string b_username { get; set; }
        public string b_email_id { get; set; }
        public string b_pwd { get; set; }
        public long b_pno { get; set; }
        
        public Buyer(int b_id,string b_username,string b_email_id,string b_pwd,long b_pno)
        {
            this.b_id = b_id;
            this.b_username = b_username;
            this.b_email_id = b_email_id;
            this.b_pwd = b_pwd;
            this.b_pno = b_pno;
        }
    }
}
