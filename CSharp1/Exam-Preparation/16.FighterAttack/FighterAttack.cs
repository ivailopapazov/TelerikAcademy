using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FighterAttack
{
    static void Main()
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());
        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        fx += d;
        int damage = 0;

        // Plant dimensions
        int maxX = Math.Max(px1, px2);
        int minX = Math.Min(px1, px2);
        int maxY = Math.Max(py1, py2);
        int minY = Math.Min(py1, py2);

        // Missile hit
        if (fx >= minX && fx <= maxX)
        {
            if (fy >= minY && fy <= maxY)
            {
                damage += 100;
            }
            if (fy + 1 >= minY && fy + 1 <= maxY)
            {
                damage += 50;
            }
            if (fy - 1 >= minY && fy - 1 <= maxY)
            {
                damage += 50;
            }
        }
        if (fx + 1 >= minX && fx + 1 <= maxX)
        {
            damage += 75;
        }
        Console.WriteLine("{0}%", damage);
    }
}
