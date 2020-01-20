using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMartProject
{
    abstract class Category
    {
        public int c_id { get; set; }
        public string c_name { get; set; }
        static List<Category> clist = new List<Category>();
        public Category(int c_id, string c_name)
        {
            this.c_id = c_id;
            this.c_name = c_name;
        }
        
    }
}
