namespace _3.Supermarket2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    class Program
    {
        static Dictionary<string, Product> products = new Dictionary<string, Product>();
        static Dictionary<string, SortedSet<Product>> categories = new Dictionary<string, SortedSet<Product>>();
        static OrderedSet<Product> sortedProducts = new OrderedSet<Product>();

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
                        if (!categories.ContainsKey(categoryName))
                        {
                            categories.Add(categoryName, new SortedSet<Product>());
                        }


                        double price = double.Parse(command[2]);
                        var currentProduct = new Product(name, price, categoryName);
                        products.Add(name, currentProduct);
                        sortedProducts.Add(currentProduct);
                        categories[categoryName].Add(currentProduct);

                        Console.WriteLine("Ok: Product {0} added successfully", name);
                    }

                }
                else if (command[0] == "filter")
                {
                    if (command[2] == "type")
                    {
                        var currentType = command[3];

                        if (!categories.ContainsKey(currentType))
                        {
                            Console.WriteLine("Error: Type {0} does not exists", currentType);
                        }
                        else
                        {
                            var result = categories[currentType].Take(10).ToList();
                            Console.WriteLine("Ok: {0}", string.Join(", ", result));
                        }
                    }
                    else if (command[2] == "price")
                    {
                        Product minProduct = new Product("minproduct", double.MinValue, "test");
                        Product maxProduct = new Product("maxProduct", double.MaxValue, "test");

                        bool inRange = false;

                        if (command[3] == "from")
                        {
                            minProduct.Price = double.Parse(command[4]);

                            if (command.Length > 5)
                            {
                                maxProduct.Price = double.Parse(command[6]);
                            }
                        }
                        else // to
                        {
                            maxProduct.Price = double.Parse(command[4]);
                        }

                        var result = sortedProducts.Range(minProduct, true, maxProduct, true).Take(10).ToList();

                        Console.WriteLine("Ok: {0}", string.Join(", ", result));
                    }

                }

                line = Console.ReadLine();
            }
        }
    }

    class Product : IComparable<Product>
    {
        public Product(string name, double price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Type { get; set; }


        public int CompareTo(Product other)
        {
            if (this.Price > other.Price)
            {
                return 1;
            }
            else if (this.Price < other.Price)
            {
                return -1;
            }
            else
            {
                int result = this.Name.CompareTo(other.Name);
                if (result == 0)
                {
                    return this.Type.CompareTo(other.Type);
                }

                return result;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Price);
        }
    }   
}


