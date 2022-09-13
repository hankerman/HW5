using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Market
    {

        private string name;
        private string adres;
        private string profil;
        private string telephone;
        private string email;
        private double square;
        private Products[] products;
        public string Name
        {
            get { return Name; }
        }
        public string Adres
        {
            get { return adres; }
        }
        public string Profil
        {
            get { return profil; }
            set { profil = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public double Square
        {
            get { return square; }
            set { square = value; }
        }

        public Market()
        {
            name = "No name";
            adres = "kudikina gora";
            telephone = "000-000";
            email = "lucomorie@dub.zeleniy";
            square = 39.10;
            profil = name + "\n" + adres + "\n" + telephone + "\n" + email;
        }

        public Market(string name, string adres)
        {

            this.name = name;
            this.adres = adres;
            telephone = "000-000";
            email = "chtoto@mail.bu";
            square = 40;
            profil = name + "\n" + adres + "\n" + telephone + "\n" + email;

        }

        public Market(string name, string adres, double square)
        {

            this.name = name;
            this.adres = adres;
            telephone = "000-000";
            email = "chtoto@mail.bu";
            this.square = square;
            profil = name + "\n" + adres + "\n" + telephone + "\n" + email;

        }

        public Market(double square)
        {
            name = "No name";
            adres = "kudikina gora";
            telephone = "000-000";
            email = "lucomorie@dub.zeleniy";
            this.square = square;
            profil = name + "\n" + adres + "\n" + telephone + "\n" + email;
        }

        void PrintProd()
        {

            foreach (Products p in products)
            {
                Console.WriteLine(p.Name + " в колличестве - " + p.Quantity);
            }

        }

        void PrintProfil()
        {

            Console.WriteLine(Profil);

        }

        void RedacProfil()
        {
            Console.WriteLine("Введите номер телефона");
            Telephone = Console.ReadLine();
            Console.WriteLine("Введите электроную почту");
            Email = Console.ReadLine();
            profil = name + "\n" + adres + "\n" + telephone + "\n" + email;

        }

        void RedacProfil(string telephone, string email)
        {

            Telephone = telephone;
            Email = email;

            profil = name + "\n" + adres + "\n" + telephone + "\n" + email;

        }

        void refill(string name, int quantity)
        {

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    products[i].Quantity = quantity;
                }
                else
                {
                    Console.WriteLine("Продукт не найден");
                }
            }

        }

        void SellPod(string name, int quantity)
        {

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    if (products[i].Quantity >= quantity)
                    {
                        products[i].Quantity -= quantity;
                    }
                    else
                    {
                        Console.WriteLine("Не хватает товара");
                    }

                }
                else
                {
                    Console.WriteLine("Продукт не найден");
                }
            }

        }

        void AddProduct(string name)
        {
            Products temp = new Products(name);
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = temp;

        }

        void AddProduct(string name, int quantity)
        {
            Products temp = new Products(name, quantity);
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = temp;

        }

        public override bool Equals(object obj)
        {
            return this.square == ((Market)obj).square;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator == (Market a, Market b)
        {
            return a.Equals(b);
        }

        public static bool operator != (Market a, Market b)
        {
            return !a.Equals(b);
        }

        public static bool operator < (Market a, Market b)
        {
            return a.square < b.square;
        }

        public static bool operator > (Market a, Market b)
        {
            return a.square > b.square;
        }

        public static Market operator + (Market a, double n)
        {
            a.square = a.square + n;
            return a;
        }

        public static Market operator -(Market a, double n)
        {
            a.square = a.square - n;
            return a;
        }

    }
}
