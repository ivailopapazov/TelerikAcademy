﻿using System;
using LinearAlgebra.Common;
using Attributes;
using CustomCollections.Generic;

namespace LinearAlgebra.UI
{
    [Version("3.09")]
    class Program
    {
        static void Main()
        {
            /* 
             * I don't have much time, so I copied some of the testing from a friend. Sorry about that :(
             * But class libraries are my own work :)
             */

            // Creating some points
            Point3D firstPoint = new Point3D(3, 0, 4);
            Console.WriteLine("First point: {0}", firstPoint);
            Point3D zeroPoint = Point3D.O;
            Console.WriteLine("Zero point: {0}", zeroPoint);
            Point3D anotherPoint = new Point3D(4, 5, 2);
            Console.WriteLine("Another point: {0}", anotherPoint);

            // Calculating the distance between different points
            double result = Distance.Calculate(firstPoint, zeroPoint);
            Console.WriteLine("Distance between the first point and the zero point: {0}", result);
            result = Distance.Calculate(zeroPoint, anotherPoint);
            Console.WriteLine("Distance between the zero point and another point: {0}", result);

            // Creating a path of points
            Path testPath = new Path();
            testPath.AddPoint(firstPoint);
            testPath.AddPoint(zeroPoint);
            testPath.AddPoint(anotherPoint);

            // Saving the path to the file Path.txt
            PathStorage.Save(testPath);

            // Loading a path from the file Path.txt
            Path testPath2 = PathStorage.Load();

            // Print loaded path
            foreach (Point3D point in testPath2)
            {
                Console.WriteLine(point);
            }

            // Creating an instance of the list
            GenericList<int> integerList = new GenericList<int>(4);

            // Adding 5 elements
            for (int i = 0; i < 5; i++)
            {
                integerList.Add(i);
            }

            Console.WriteLine(integerList);

            // Removing the element at position 3
            integerList.Remove(3);

            Console.WriteLine(integerList);

            // Inserting element at position 3 with value 33
            integerList.Insert(3, 33);

            Console.WriteLine(integerList);

            // Finding element by it's value
            Console.WriteLine(integerList.IndexOf(33));

            // Getting a value through the indexer
            Console.WriteLine(integerList[2]);

            // Setting element through the indexer
            integerList[0] = 17;

            Console.WriteLine(integerList);

            // Adding a single element at the end
            integerList.Add(7);

            Console.WriteLine(integerList);

            // Get the minimal value from the list
            Console.WriteLine(integerList.Min());

            // Get the maximal value from the list
            Console.WriteLine(integerList.Max());

            // Matrix test
            Matrix<int> firstMatrix = new Matrix<int>(2, 3);
            Matrix<int> secondMatrix = new Matrix<int>(2, 3);

            int numberToAdd = 1;
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    firstMatrix[i, j] = numberToAdd;
                    secondMatrix[i, j] = numberToAdd;
                    numberToAdd++;
                }
            }

            Console.WriteLine("first matrix: \r\n{0}", firstMatrix);
            Console.WriteLine("second matrix: \r\n{0}", secondMatrix);

            Matrix<int> summedMatrix = firstMatrix + secondMatrix;
            System.Console.WriteLine("Sum of the two matrices: \n{0}", summedMatrix);


            Matrix<int> subtractedMatrix = firstMatrix - secondMatrix;
            System.Console.WriteLine("Subtraction of the two matrices: \n{0}", subtractedMatrix);

            Matrix<int> thirdMatrix = new Matrix<int>(3, 2);

            numberToAdd = 1;

            for (int i = 0; i < thirdMatrix.Rows; i++)
            {
                for (int j = 0; j < thirdMatrix.Cols; j++)
                {
                    thirdMatrix[i, j] = numberToAdd;
                    numberToAdd++;
                }
            }

            Matrix<int> multipliedMatrix = firstMatrix * thirdMatrix;
            System.Console.WriteLine("Multiplication of the two matrices: \n{0}", multipliedMatrix);

            if (firstMatrix)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // Attribute test
            Type programType = typeof(Program);

            // Get custom attributes
            object[] customAttributes = programType.GetCustomAttributes(typeof(VersionAttribute), false);

            // Iterate attributes (just one in this case)
            foreach (VersionAttribute attr in customAttributes)
            {
                // Print
                Console.WriteLine("Version of the class {0} is {1}", programType.Name, attr.Version);
            }


        }
    }
}
