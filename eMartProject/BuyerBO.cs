using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMartProject
{
    class BuyerBO
    {
        static List<Buyer> blist = new List<Buyer>();
        ItemBO iobj = new ItemBO();

        public void SignUp(int b_id, string s_username, string s_email_id, string s_pwd, long b_pno)
        {


            blist.Add(new Buyer(b_id, s_username, s_email_id, s_pwd, b_pno));
           

        }
        public bool login(string s_username, string s_pwd)
        {

            Buyer bobj = blist.Find(e => e.b_username == s_username && e.b_pwd == s_pwd);
            if (bobj != null) return true;
            else return false;
        }
        public void display_items()
        {
            iobj.displayItems();
        }
        public void search()
        {
            iobj.search();
        }
        public void display_buyers()
        {
            foreach(Buyer b in blist)
            {
                Console.WriteLine("Buyer id\tBuyer name\temail id\t\tPhone number");
                Console.WriteLine(b.b_id + "\t" + b.b_username+"\t"+b.b_email_id+"\t"+b.b_pno);
              
            }
        }
    }
}
