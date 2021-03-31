using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1_finalproject
{
    class Product
    {
        int _stock;
        string _Company;
        string _Type;

        public int Stock { get => _stock; set => _stock = value; }
        public string Company { get => _Company; set => _Company = value; }
        public string Type { get => _Type; set => _Type = value; }
    }
}
