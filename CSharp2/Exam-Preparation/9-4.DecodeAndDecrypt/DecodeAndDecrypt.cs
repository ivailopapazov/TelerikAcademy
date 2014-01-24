using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://bgcoder.com/Contests/Submissions/View/295617

namespace _9_4.DecodeAndDecrypt
{
    class DecodeAndDecrypt
    {
        static void Main(string[] args)
        {
            // Input
            string input = Console.ReadLine();

            int cipherLength = 0;

            // get cipher length
            for (int i = input.Length - 1 ; i >= 0; i--)
            {
                if (!int.TryParse(input.Substring(i), out cipherLength))
                {
                    cipherLength = int.Parse(input.Substring(++i));
                    input = input.Substring(0, i);
                    break;
                }
            }

            // Decode
            input = Decode(input);

            // Get cipher
            string cipher = input.Substring(input.Length - cipherLength); 
            StringBuilder message = new StringBuilder(input.Substring(0, input.Length - cipherLength));

            if (message.Length < cipherLength)
            {
                int pos = (cipherLength % message.Length) - 1;

                for (int i = cipherLength - 1; i >= 0; i--)
                {
                    if (pos < 0)
                    {
                        pos = message.Length - 1;
                    }
                    char letter = (char)('A' + ((cipher[i] - 'A') ^ (message[pos] - 'A')));
                    message[pos] = letter;
                    pos--;
                }
            }
            else
            {
                for (int i = 0, j = 0; i < message.Length; i++, j++)
                {
                    if (j >= cipherLength)
	                {
                        j -= cipherLength;
	                }
                    message[i] = (char)('A' + ((cipher[j] - 'A') ^ (message[i] - 'A')));
                }
            }

            Console.WriteLine(message);
        }

        static string Decode(string input)
        {
            StringBuilder decoded = new StringBuilder();
            string digit = "";

            for (int i = 0; i < input.Length; i++)
            {       
                if (char.IsDigit(input[i]))
                {
                    while (char.IsDigit(input[i]))
                    {
                        digit += input[i++].ToString();
                    }
                    decoded.Append(new string(input[i], int.Parse(digit)));
                    digit = String.Empty;
                }
                else
                {
                    decoded.Append(input[i]);
                }
            }

            return decoded.ToString();
        }
    }
}
