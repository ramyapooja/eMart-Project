using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMartProject
{
    class SubCategory:Category
    {
        public int sc_id { get; set; }
        public string sc_name { get; set; }
        
        public int GST { get; set; }
        public SubCategory(int c_id,string c_name,int sc_id,string sc_name,int GST):base(c_id,c_name)
        {
            this.c_id = c_id;
            this.c_name = c_name;
            this.sc_id = sc_id;
            this.sc_name = sc_name;
            this.GST = GST;
        }
    }
}
