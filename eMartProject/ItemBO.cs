using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMartProject
{
    class ItemBO
    {
        static List<Item> iblist = new List<Item>();
        static List<SubCategory> sclist = new List<SubCategory>();
        public void add_item(int item_id, int c_id, string c_name, int sc_id, string sc_name, int GST, string item_name, int stock_number, double price,int s_id)
        {
            SubCategory sobj = new SubCategory(c_id, c_name, sc_id, sc_name, GST);
            Item iobj = new Item(item_id, item_name, stock_number, price, s_id);
            sclist.Add(sobj);
            iblist.Add(iobj);
            Console.WriteLine("Item added successfully!!!!! ");
        }
        public List<Item> displayItems(int sid)
        {
            List<Item> ilist = iblist.FindAll(e => e.s_id == sid);
            return ilist;
        }
            public void displayItems()
        {
            foreach(Category i in sclist)
            {
                Console.WriteLine("Category id\tcategory name");
                Console.WriteLine(i.c_id + "\t" + i.c_name);
            }
            Console.WriteLine("Enter category id to see sub categories:");
            int ch = int.Parse(Console.ReadLine());
            foreach(SubCategory i in sclist)
            {
                if(i.c_id==ch)
                {
                    Console.WriteLine("Sub category id\tSubcategory name\tGST");
                    Console.WriteLine(i.sc_id + "\t" + i.sc_name+"\t"+i.GST);
                }
            }
            Console.WriteLine("Enter subcategory id to see items present in the list:");
            int n = int.Parse(Console.ReadLine());
            foreach (SubCategory s in sclist)
            {
                foreach (Item i in iblist)
                {
                    if (s.sc_id == n)
                    {
                        Console.WriteLine("Item id\tItem name\tPrice");
                        Console.WriteLine(i.item_id + "\t" + i.item_name + "\t" + i.price);
                    }
                }
            }
        }
        public void search()
        {
            Console.WriteLine("1.Search an item by using item id\n2.Search an item by using item name");
            int n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("Enter item id:");
                int a=int.Parse(Console.ReadLine());
                int f = 0;
                foreach(Item i in iblist)
                {
                    if(i.item_id==a)
                    {
                        Console.WriteLine("Item id\tItem name\tPrice");
                        Console.WriteLine(i.item_id + "\t" + i.item_name + "\t"+i.price);
                        f = 1;
                        break;
                    }
                   

                }
                if (f == 0)
                    Console.WriteLine("Item not found");
            }
            else if(n==2)
            {
                Console.WriteLine("Enter item name:");
                string b = Console.ReadLine();
                int f = 0;
                foreach (Item i in iblist)
                {
                    if (i.item_name == b)
                    {
                        Console.WriteLine("Item id\tItem name\tPrice");
                        Console.WriteLine(i.item_id + "\t" + i.item_name + "\t" + i.price);
                        f = 1;
                        break;
                    }


                }
                if (f == 0)
                    Console.WriteLine("Item not found");
            }
        }
    }
}
