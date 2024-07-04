using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkvrcovIS_PR32_1
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name=name;
            Price=price;
            Quantity=quantity;
        }
        public virtual double Quality() 
        {
            return Price / Quantity;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Названия продукта - {Name}");
            Console.WriteLine($"Цена продукта - {Price}");
            Console.WriteLine($"Количество продукта - {Quantity}");
            Console.WriteLine($"Q продукта - {Quality()}");
        }
    }
    public class ExtendProduct : Product
    {
        public int YearOfVipuska { get; set; }
        public ExtendProduct(string name, double price, int quantity, int yearofvipska) : base(name, price, quantity)
        {
            YearOfVipuska = yearofvipska;
        }
        public override double Quality()
        {
            double Q = base.Quality();
            int currentYear = DateTime.Now.Year;
            int yearsDiff = currentYear - YearOfVipuska;
            if (yearsDiff < 3)
            {
                return Q + 0.5 * yearsDiff;
            }
            else
            {
                return Q + 1.3 * yearsDiff;
            }
        }
        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Год выпуска продукта - {YearOfVipuska}");
            Console.WriteLine($"Qp продукта  - {Quality()}");
        }
    }
    public class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите информацию о продукте: ");
            Console.WriteLine("Введите названия продукта: ");
            string name;
            name = Console.ReadLine().ToString();
            Console.WriteLine("Введите цену продукта: ");
            double price;
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество продукта: ");
            int quantity;
            quantity = Convert.ToInt32(Console.ReadLine());
            Product product = new Product(name, price, quantity);
            product.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Введите информацию о Exпродукте: ");
            Console.WriteLine("Введите названия продукта: ");
            string name2;
            name2 = Console.ReadLine().ToString();
            Console.WriteLine("Введите цену продукта: ");
            double price2;
            price2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество продукта: ");
            int quantity2;
            quantity2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год выпуска товара: ");
            int god;
            god = Convert.ToInt32(Console.ReadLine());
            ExtendProduct extendProduct = new ExtendProduct(name2, price2, quantity2, god);
            extendProduct.PrintInfo();
            Console.ReadLine();
        }
        
    }
}
