using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil
{
    class Oil
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public override string ToString()
        {
            return $"\nOil - {Name}\nPrice - {Price}";
        }
    }
}
