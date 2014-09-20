namespace _3.Supermarket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    class Program
    {
        //static OrderedDictionary<string, int> products = new OrderedDictionary<string, int>(new Comparer<int>());
        static Dictionary<string, Product> products = new Dictionary<string, Product>();
        static Dictionary<string, Category> categories = new Dictionary<string, Category>();
        static OrderedDictionary<double, Product> productsByPrices = new OrderedDictionary<double, Product>();

        static void Main()
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] command = line.Split(' ');

                if (command[0] == "add")
                {
                    string name = command[1];
                    if (products.ContainsKey(name))
                    {
                        Console.WriteLine("Error: Product {0} already exists", name);
                    }
                    else
                    {
                        string categoryName = command[3];
                        Category currentCategory;
                        if (!categories.ContainsKey(categoryName))
                        {
                            currentCategory = new Category();
                            categories.Add(categoryName, currentCategory);
                        }
                        else {
                            currentCategory = categories[categoryName];
                        }

                        double price = double.Parse(command[2]);
                        var currentProduct = new Product(name, price);
                        currentCategory.Products.Add(price, currentProduct);
                        products.Add(name, currentProduct);
                        productsByPrices.Add(price, currentProduct);

                        Console.WriteLine("Ok: Product {0} added successfully", name);
                    }
                }
                else if (command[0] == "filter")
                {
                    if (command[2] == "type")
                    {
                        string type = command[3];
                        if (!categories.ContainsKey(type))
                        {
                            Console.WriteLine("Error: Type {0} does not exists", type);
                        }
                        else
                        {
                            var currentCategory = categories[type];
                            var result = currentCategory.Products.Take(10).Select(x => x.Value).OrderBy(x => x.Price).ThenBy(x => x.Name).Select(x => string.Format("{0}({1})", x.Name, x.Price)).ToList();
                            Console.WriteLine("Ok: {0}", string.Join(", ", result));
                        }
                    }
                    else if (command[2] == "price")
                    {
                        
                    }
                }

                line = Console.ReadLine();
            }
        }
    }

    class Product : IComparable<Product>
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public int CompareTo(Product other)
        {
            if (this.Price > other.Price)
            {
                return -1;
            }
            else if (this.Price < other.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

    class Category
    {
        public Category()
        {
            this.Products = new OrderedDictionary<double, Product>();
        }

        public string Name { get; set; }

        public OrderedDictionary<double, Product> Products { get; set; }
    }
}
