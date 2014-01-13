using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ShipDamage
{
    static void Main()
    {
        int[] cx = new int[3];
        int[] cy = new int[3];
        int damage = 0;

        // Input data
        int sx1 = int.Parse(Console.ReadLine());
        int sy1 = int.Parse(Console.ReadLine());
        int sx2 = int.Parse(Console.ReadLine());
        int sy2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        cx[0] = int.Parse(Console.ReadLine());
        cy[0] = int.Parse(Console.ReadLine());
        cx[1] = int.Parse(Console.ReadLine());
        cy[1] = int.Parse(Console.ReadLine());
        cx[2] = int.Parse(Console.ReadLine());
        cy[2] = int.Parse(Console.ReadLine());

        // Catapult fire
        cy[0] = 2 * h - cy[0];
        cy[1] = 2 * h - cy[1];
        cy[2] = 2 * h - cy[2];

        int shipMinX = Math.Min(sx1, sx2);
        int shipMinY = Math.Min(sy1, sy2);
        int shipMaxX = Math.Max(sx1, sx2);
        int shipMaxY = Math.Max(sy1, sy2);

        for (int i = 0; i < 3; i++)
        {
            
            if ((cx[i] == shipMinX || cx[i] == shipMaxX) && (cy[i] == shipMinY || cy[i] == shipMaxY))
            {
                damage += 25;
            }
            else if (cx[i] >= shipMinX && cx[i] <= shipMaxX && cy[i] >= shipMinY && cy[i] <= shipMaxY)
            {
                if (cx[i] == shipMinX || cx[i] == shipMaxX || cy[i] == shipMinY || cy[i] == shipMaxY)
                {
                    damage += 50;
                }
                else
                {
                    damage += 100;
                }
            }
        }
        Console.WriteLine("{0}%",damage);
    }
}
