using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Supply
    {
        public int Id { get; set; }
        public string Drink { get; set; }
        public int Stock { get; set; }

        public Supply(int id, int stock)
        {
            Id = id;
            Stock = stock;
        }

        public Supply()
        {
        }
    }
}
