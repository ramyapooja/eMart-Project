using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMartProject
{
    public class Seller
    {
         public int s_id {get ; set; }
        public string s_username { get; set; }
        public string s_pwd { get; set; }
        public string company_name { get; set; }
        public int GSTIN { get; set; }
        public string website { get; set; }
        public string s_email_id { get; set; }
        public long s_pno { get; set; }
        public string s_address { get; set; }
        public long sbank_accno { get; set; }
        public Seller(string s_username, string s_email_id,string s_pwd,string s_address,int GSTIN,long sbank_accno)
        {
            
            this.s_username = s_username;
            this.s_email_id = s_email_id;
            this.s_pwd = s_pwd;
            this.s_address = s_address;
            this.GSTIN = GSTIN;
            this.sbank_accno = sbank_accno;
           
        }
        
    }
}
