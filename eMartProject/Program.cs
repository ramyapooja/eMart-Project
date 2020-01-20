using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMartProject
{
    class Program
    {
        static void Main(string[] args)
        {
            x:
            Console.WriteLine("Are you \n1.Admin\n2.Seller\n3.Buyer");
            int n = int.Parse(Console.ReadLine());
            for (; ; )
            {
                switch (n)
                {
                    case 1:
                        break;
                    case 2:
                        Console.WriteLine("1.Signup for new user\n2.Login for existing user\n");
                        int ch = int.Parse(Console.ReadLine());
                        SellerBO sb = new SellerBO();
                        if (ch==1)
                        {
                            Console.WriteLine("Enter username:");
                            string s_username = Console.ReadLine();
                            Console.WriteLine("Enter email id:");
                            string s_email_id = Console.ReadLine();
                            Console.WriteLine("Enter Password:");
                            string s_pwd=Console.ReadLine();
                            Console.WriteLine("Enter Address:");
                            string s_address = Console.ReadLine();
                            Console.WriteLine("Enter GSTIN");
                            int GSTIN = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Bank account no:");
                            long sbank_accno = int.Parse(Console.ReadLine());
                            sb.SignUp(s_username,s_email_id,s_pwd,s_address,GSTIN,sbank_accno);
                            Console.WriteLine("Signup successfully!!!");
                            
                        }
                        else if(ch==2)
                        {
                            Console.WriteLine("Enter username:");
                            string s_username = Console.ReadLine();
                            Console.WriteLine("Enter password:");
                            string s_pwd = Console.ReadLine();
                            bool x=sb.login(s_username,s_pwd);
                            if (x != true)
                                Console.WriteLine("Sorry,Invalid login credentials!!!");
                            else
                            {
                                for (; ; )
                                { 
                                    Console.WriteLine("1.Sellers details\n2.Add items\n3.Display seller items\n4.Display list of remaining items\n5.Display daily report over sold items\n6.GST calculation 7.Exit");
                                    int b = int.Parse(Console.ReadLine());
                                
                                
                                    switch (b)
                                    {
                                        case 1:
                                            Console.WriteLine("Sellers details");
                                            sb.display_sellers();
                                            break;
                                        case 2:
                                            Console.WriteLine("Enter number of items you want to add:");
                                            int a = int.Parse(Console.ReadLine());
                                            ItemBO io = new ItemBO();
                                            for (int i = 0; i < a; i++)
                                            {
                                                Console.WriteLine("Enter item id:");
                                                int item_id = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter category id:");
                                                int c_id = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter category name:");
                                                string c_name = Console.ReadLine();
                                                Console.WriteLine("Enter subcategory id:");
                                                int sc_id = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter subcategory name:");
                                                string sc_name = Console.ReadLine();
                                                Console.WriteLine("Enter GST:");
                                                int GST = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter item name:");
                                                string item_name = Console.ReadLine();
                                                Console.WriteLine("Enter number of items:");
                                                int stock_number = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter price of each item:");
                                                double price = double.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter seller id:");
                                                int s_id = int.Parse(Console.ReadLine());
                                                io.add_item(item_id, c_id, c_name, sc_id, sc_name, GST, item_name, stock_number, price, s_id);
                                            }


                                            break;
                                        case 3:
                                            sb.displaySitems();
                                            break;
                                        case 7:
                                            goto x;
                                            
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("1.Signup for new user\n2.Login for existing user\n");
                        int c = int.Parse(Console.ReadLine());
                        BuyerBO bb = new BuyerBO();
                        if (c == 1)
                        {
                            Console.WriteLine("Enter buyer id:");
                            int b_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter username:");
                            string b_username = Console.ReadLine();
                            Console.WriteLine("Enter email id:");
                            string b_email_id = Console.ReadLine();
                            Console.WriteLine("Enter Password:");
                            string b_pwd = Console.ReadLine();
                            Console.WriteLine("Enter Bank account no:");
                            long b_pno = int.Parse(Console.ReadLine());
                            bb.SignUp(b_id,b_username, b_email_id, b_pwd, b_pno);
                            Console.WriteLine("Signup successfully!!!");

                        }
                        else 
                        {
                            Console.WriteLine("Enter username:");
                            string b_username = Console.ReadLine();
                            Console.WriteLine("Enter password:");
                            string b_pwd = Console.ReadLine();
                            bool y = bb.login(b_username, b_pwd);
                            if (y!= true)
                                Console.WriteLine("Sorry,Invalid login credentials!!!");
                            else
                            {
                                while(true)
                                {
                                    Console.WriteLine("1.Display\n2.Search\n3.Display details");
                                    int c1 = int.Parse(Console.ReadLine());
                                    if (c1 == 1)
                                    {
                                        bb.display_items();
                                    }
                                    else if (c1 == 2)
                                    {
                                        bb.search();
                                    }
                                    else if (c1 == 3)
                                    {
                                        bb.display_buyers();
                                    }
                                    else
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}
