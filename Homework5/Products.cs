using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Products
    {

        private string name;
        private int quantity;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
            }
        }

        public Products()
        {
            name = "No name";
            quantity = 0;
        }

        public Products(string name)
        {
            this.name = name;
            quantity = 1;
        }
        public Products(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }

    }
}
