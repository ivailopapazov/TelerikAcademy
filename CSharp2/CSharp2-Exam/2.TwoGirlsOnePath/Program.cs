using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2.TwoGirlsOnePath
{
    public class Girl
    {
        public long pos;
        public long newPos;
        public BigInteger flowers;
        public bool finished;
        public Girl(int startPos)
        {
            pos = startPos;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // input
            long[] path = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

            Girl molly = new Girl(0);
            Girl dolly = new Girl(path.Length - 1);
            bool samePlace = false;

            while (true)
            {
                // Collect flowers
                if (molly.pos == dolly.pos)
                {
                    // same place
                    samePlace = true;
                    molly.flowers += path[molly.pos] / 2;
                    dolly.flowers += path[dolly.pos] / 2;
                }
                else
                {
                    molly.flowers += path[molly.pos];
                    dolly.flowers += path[dolly.pos];
                }

                // check if position is empty
                if (path[molly.pos] == 0 || path[dolly.pos] == 0)
                {
                    if (path[molly.pos] == 0)
                    {
                        molly.finished = true;   
                    }
                    if (path[dolly.pos] == 0)
                    {
                        dolly.finished = true;
                    }
                    break;
                }

                // take new positions
                molly.newPos = (molly.pos + path[molly.pos]) % path.Length;
                dolly.newPos = dolly.pos - (path[dolly.pos] % path.Length);
                if (dolly.newPos < 0)
                {
                    dolly.newPos = path.Length + dolly.newPos;
                }

                // harvest flowers
                if (samePlace)
                {
                    if (path[molly.pos] % 2 == 1)
                    {
                        path[molly.pos] = 1;
                    }
                    else
                    {
                        path[molly.pos] = 0;
                    }
                    samePlace = false;
                }
                else
                {
                    path[molly.pos] = 0;
                    path[dolly.pos] = 0;
                }


                // move girls
                molly.pos = molly.newPos;
                dolly.pos = dolly.newPos;
            }

            // print
            if (molly.finished & dolly.finished)
            {
                Console.WriteLine("Draw");
            }
            else if (molly.finished)
            {
                Console.WriteLine("Dolly");   
            }
            else
            {
                Console.WriteLine("Molly");   
            }
            Console.WriteLine("{0} {1}", molly.flowers, dolly.flowers);
        }
    }
}
