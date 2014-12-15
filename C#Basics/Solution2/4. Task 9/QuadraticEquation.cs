﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace _4.Task_9
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            double a, b, c, discriminant;
            bool success;
            
            Console.Write("Enter \"a\": ");
            success = double.TryParse(Console.ReadLine(), out a);
            while (!success)
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter \"a\": ");
                success = double.TryParse(Console.ReadLine(), out a);
            }

            Console.Write("Enter \"b\": ");
            success = double.TryParse(Console.ReadLine(), out b);
            while (!success)
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter \"b\": ");
                success = double.TryParse(Console.ReadLine(), out b);
            }

            Console.Write("Enter \"c\": ");
            success = double.TryParse(Console.ReadLine(), out c);
            while (!success)
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter \"c\": ");
                success = double.TryParse(Console.ReadLine(), out c);
            }

            if ((a+b+c)==0)
            {
                double x1 = 1;
                double x2 = c / a;
                Console.WriteLine("The Equation has two real roots");
                Console.WriteLine("The first root is: " + x1);
                Console.WriteLine("The socond root is: " + x2);
                return;
            }
            else if ((a-b+c)==0)
            {
                double x1 = -1;
                double x2 = -c/a;
                Console.WriteLine("The Equation has two real roots");
                Console.WriteLine("The first root is: " + x1);
                Console.WriteLine("The socond root is: " + x2);
                return;
            }

            discriminant = Math.Pow(b,2)-(4*a*c);
            if (discriminant<0)
            {
                Console.WriteLine("The Equation has no real roots!!!");
            }
            else if (discriminant==0)
            {
                Console.WriteLine("The Equation has one real root: {0}", -b/(2*a));

            }
            else
            {
                double x1, x2;
                x1 = (-b + Math.Sqrt(discriminant))/(2*a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The Equation has two real roots");
                Console.WriteLine("The first root is: " + x1);
                Console.WriteLine("The socond root is: " + x2);

            }


        }
    }
}
