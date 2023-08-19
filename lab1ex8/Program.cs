using System;

namespace lab1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex8
            Scrieti un program care interschimba valoarea a doua variabile intregi. */

            int x;
            int y;

            Console.WriteLine("Enter x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y: ");
            y = int.Parse(Console.ReadLine());

            //variabiala auxiliar z
            int z = x;
            x = y;
            y = z;

            Console.WriteLine(x + ","+ y);
            
        }
    }
}
