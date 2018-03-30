using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs3Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("conversation failed");
        }

        static void Useparamss()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(11, 4, 7, 8));
            Console.WriteLine(calculator.Add(new[] { 1, 2, 3, 4, 5, 6, 7 }));
        }

        static void UsePoints()
        {
            try
            {
                Point point = new Point(10, 20);
                point.Move(null); //indor to use exception
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error has occured");
            }
        }
    }
}
