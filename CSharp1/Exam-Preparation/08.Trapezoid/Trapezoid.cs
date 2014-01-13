using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = n; i >= 0; i--)
        {
            char[] row = new string('.', 2 * n).ToArray();

            if (i == n || i == 0)
            {
                for (int j = i; j < row.Length; j++)
                {
                    row[j] = '*';
                }
            }
            else
            {
                row[i] = '*';
                row[2 * n - 1] = '*';
            }
            Console.WriteLine(new string(row));
        }
    }
}
