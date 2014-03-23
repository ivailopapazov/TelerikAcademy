namespace SimpleDataStructures
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            int size = 10000000;

            Console.WriteLine("Testing stacks with {0} pushes and {0} pops", size);
            Console.WriteLine(TestStack(new LinkedStack<string>(), size));
            Console.WriteLine(TestStack(new Stack<string>(), size));
            Console.WriteLine(TestSystemStack(new System.Collections.Generic.Stack<String>(), size));
        }
        
        static string TestStack(IStack<string> stack, int size)
        {
            StringBuilder result = new StringBuilder();
            Stopwatch sw = new Stopwatch();

            result.AppendFormat("Test Stack: {0}", stack.GetType().Name).AppendLine();

            // Testing push
            sw.Start();
            for (int i = 0; i < size; i++)
            {
                stack.Push(i.ToString());
            }
            sw.Stop();
            result.AppendFormat("Push test time: {0}", sw.Elapsed).AppendLine();
            sw.Reset();

            // Testing pop
            sw.Start();
            for (int i = 0; i < size; i++)
            {
                stack.Pop();
            }
            sw.Stop();

            result.AppendFormat("Pop test time: {0}", sw.Elapsed);

            return result.ToString();
        }

        static string TestSystemStack(System.Collections.Generic.Stack<String> stack, int size)
        {
            StringBuilder result = new StringBuilder();
            Stopwatch sw = new Stopwatch();

            result.AppendFormat("Test Stack: {0}", stack.GetType().Name).AppendLine();

            // Testing push
            sw.Start();
            for (int i = 0; i < size; i++)
            {
                stack.Push(i.ToString());
            }
            sw.Stop();
            result.AppendFormat("Push test time: {0}", sw.Elapsed).AppendLine();
            sw.Reset();

            // Testing pop
            sw.Start();
            for (int i = 0; i < size; i++)
            {
                stack.Pop();
            }
            sw.Stop();

            result.AppendFormat("Pop test time: {0}", sw.Elapsed);

            return result.ToString();
        }
    }
}
