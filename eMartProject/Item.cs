using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMartProject
{
    class Item
    {
        internal int sc_id;
        public string c_name{get;set;}
        public string sc_name { get; set; }
        public int item_id { get; set; }
        public int s_id { get; set; }
        public double price { get; set; }
        public string item_name { get; set; }
        public int stock_number { get; set; }
        public int no_of_items { get; set; }
        List<Item> ilist = new List<Item>();

        public Item(int item_id,string item_name,int stock_number,double price,int s_id)
        {
            this.item_id = item_id;
            
        
            this.item_name = item_name;
            this.stock_number = stock_number;
            this.price = price;
            this.s_id = s_id;
        }
        public void display_items()
        {
            Console.WriteLine("Item name:" + item_name);
            Console.WriteLine("Category name:" + c_name);
            Console.WriteLine("Sub category name:" + sc_name);
            Console.WriteLine("Price:" + price);
        }
    }
}
