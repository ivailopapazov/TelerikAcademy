namespace SimpleDataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var test = new LinkedStack<int>();

            test.Push(1);
            test.Push(2);
            test.Push(3);
            test.Push(4);
            test.Push(5);
            Console.WriteLine(test.Peak());
            Console.WriteLine(test.Pop());
            Console.WriteLine(test.Peak());
        }
    }
}
