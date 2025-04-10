using System;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(0.5f, 0.2f);
            Triangle t2 = new Triangle(Console.ReadLine(), "0.2");

            Console.WriteLine(t1.Area());

            Console.ReadLine();
        }
    }
}