using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CartesianCoordinateSystem
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double arctan = Math.Atan2(y, x);
        double pi = Math.PI;

        if (arctan > 0 && arctan < pi / 2)
        {
            Console.WriteLine(1);
        }
        else if (arctan > pi / 2 && arctan < pi)
        {
            Console.WriteLine(2);
        }
        else if (arctan < 0 && arctan > -pi / 2)
        {
            Console.WriteLine(4);
        }
        else if (arctan > -pi && arctan < -pi / 2)
        {
            Console.WriteLine(3);
        }
        else if (Math.Abs(arctan) == pi / 2)
        {
            Console.WriteLine(5);
        }
        else
        {
            if (x == 0 && y == 0)
            {
                Console.WriteLine(0);
            }
            else if (arctan == 0 || arctan == pi)
            {
                Console.WriteLine(6);
            }
        }
    }
}
