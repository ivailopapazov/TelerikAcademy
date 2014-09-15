namespace _1.MessageInABottle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        static Dictionary<string, char> dict = new Dictionary<string, char>();
        static int variations = 0;

        static void Main()
        {
            string message = Console.ReadLine();
            string cipher = Console.ReadLine();

            char currentChar = cipher[0];
            int index = 0;
            StringBuilder currentString = new StringBuilder();
            for (int i = 1; i < cipher.Length; i++)
            {
                if (cipher[i] >= 'A' && cipher[i] <= 'Z')
                {
                    dict.Add(currentString.ToString(), currentChar);
                    currentChar = cipher[i];
                    currentString.Clear();
                }
                else
                {
                    currentString.Append(cipher[i]);
                }
            }

            dict.Add(currentString.ToString(), currentChar);

            Decipher(message, 0);
        }

        static void Decipher(string message, int index)
        {
            if (index >= message.Length)
            {
                variations++;
                return;
            }

            foreach (var number in dict)
            {
                if (message.IndexOf(number.Key, index) == index)
                {
                    Decipher(message, index + number.Key.Length);
                }
            }

            Decipher(message, index + 1);
        }
    }
}
