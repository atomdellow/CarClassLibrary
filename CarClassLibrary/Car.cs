using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car ()
        {
            this.Make = "Nothing Yet";
            this.Model = "Nothing Yet";
            this.Price = 0.00M;
        }
        public Car (string a , string b , decimal c)
        {
            Make = a;
            Model = b;
            Price = c;
        }
        override public String ToString()
        {
            return "Make: " + Make + " Model" + Model + "Price: $" + Price;
        }
    }
}
