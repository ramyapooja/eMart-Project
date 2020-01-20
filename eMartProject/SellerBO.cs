using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMartProject
{
    class SellerBO
    {
        static List<Seller> slist = new List<Seller>();
       // static List<Item> il = new List<Item>();
        public void SignUp(string s_username,string s_email_id,string s_pwd,string s_address,int GSTIN, long sbank_accno)
        {
           
          
            slist.Add(new Seller(s_username, s_email_id,s_pwd, s_address, GSTIN, sbank_accno));
           
        }
        public bool login(string s_username, string s_pwd)
        {

            Seller sobj = slist.Find(e => e.s_username == s_username&&e.s_pwd==s_pwd);
                if(sobj!=null)return true;
            else return false;
            
        }
        public void display_sellers()
        {
            foreach(Seller s in slist)
            {
                Console.WriteLine("Seller id\tSeller name\temail id\tPhone number");
                Console.WriteLine(s.s_id + "\t" + s.s_username + "\t" + s.s_email_id + "\t" + s.s_pno);
            }
        }
        public void displaySitems()
        {
            ItemBO iBo = new ItemBO();
            Console.WriteLine("Enter seller id to display items of that particular seller:");
            int n = int.Parse(Console.ReadLine());
            List<Item> l = iBo.displayItems(n);
            foreach(Item i in l)
            {
                Console.WriteLine("Item id\tItem name\tItem price");
                Console.WriteLine(i.item_id + "\t" + i.item_name + "\t" + i.price);
            }
            
        }

    }
}
