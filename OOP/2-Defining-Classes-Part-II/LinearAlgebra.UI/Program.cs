using System;
using System.Collections.Generic;
using LinearAlgebra.Common;
using CustomCollections.Generic;

namespace LinearAlgebra.UI
{
    class Program
    {
        static void Main()
        {
            //Path path = new Path();
            //path.AddPoint(Point3D.O);
            //path.AddPoint(new Point3D(1.2, -2, -3.4));

            //foreach (var point in path)
            //{
            //    Console.WriteLine(point);
            //}

            //Console.WriteLine("--------------");


            //PathStorage.Save(path);

            //Console.WriteLine("--------------");

            //Path asd = PathStorage.Load();

            //Console.WriteLine("--------------");
            //foreach (var item in asd)
            //{
            //    Console.WriteLine(item);
            //}

            GenericList<int> asd = new GenericList<int>();
            asd.Add(1);
            asd.Add(3);
            asd.Add(5);
            asd.Add(10);
            asd.Add(0);
            Console.WriteLine(asd.Min());
        }
    }
}
