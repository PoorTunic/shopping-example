using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devproject
{
    class Producto
    {
        public static List<Producto> Cart { get; set; } = new List<Producto>();

        private String name;
        private Double price;

        public String Name { get { return this.name; } set { this.name = value; } }
        public Double Price { get { return this.price; } set { this.price = value; } }

        public static double GetTotal()
        {
            Double suma = 0.0;
            Double total = 0.0;
            if (Producto.Cart.Count == 0)
            {
                return total;
            }
            foreach (Producto pro in Cart)
            {
                suma = suma + pro.Price;
            }
            double resta;
            if (suma >= 800)
            {
                resta = suma * .25;
                total = suma - resta;
                return total;
            }
            else if (suma > 650)
            {

                resta = suma * .20;
                total = suma - resta;
                return total;
            }
            else if (suma > 500)
            {

                resta = suma * .16;
                total = suma - resta;
                return total;
            }
            else
            {
                total = suma;
                return total;
            }
        }

        public override string ToString()
        {
            return "{Name:" + Name + ",Price:" + Price.ToString() + "}";
        }
        public String Ticket()
        {
            return String.Format("{0} . . . . . ${1}", this.name, this.price).ToString();
        }
    }
}
