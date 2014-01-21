using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> commands = new Dictionary<int, string>();

        // Input
        string inputLine = Console.ReadLine();
        while (inputLine != "RUN")
        {
            string[] splitLine = inputLine.Split(new char[] { ' ' }, 2);
            commands.Add(int.Parse(splitLine[0]), splitLine[1]);
            inputLine = Console.ReadLine();
        }

        int[] indexes = new int[commands.Keys.Count];
        commands.Keys.CopyTo(indexes, 0);

        for (int i = 0; i < indexes.Length; i++)
        {
            
        }




        //foreach (var command in commands)
        //{
        //    Console.WriteLine(command.Key + " - " + command.Value);
        //}
    }
}
