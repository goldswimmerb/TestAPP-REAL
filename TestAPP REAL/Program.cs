using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace
namespace TestAPP_REAL
{
    //Class (Functions)
    class Program
    {
        //Function (Entry Point)
        static void Main(string[] args)
        {
            //variables
            //String st = "Hello There";
            //int 78stuff = 16;

            //Starting point of everything
            //Console.WriteLine(st);
            Console.WriteLine("Type any number");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            // PrintFooToScreen();
            PrintFooToScreen100Times();
            if (keyInfo.KeyChar == 'a')
            {
                Console.WriteLine(" ");

                Console.WriteLine("Thats not a numer! Staph it");
            }

            else
            {
                Console.WriteLine(" ");

                Console.WriteLine("Did you type {0}", keyInfo.KeyChar.ToString());
            }
        }
        static void PrintFooToScreen()
        {
            // all this does is print foo to the screen
            Console.WriteLine("Foo");
        }
        static void PrintFooToScreen100Times()
        {
            for (int i = 0; i < 100; i++)
            {
                PrintFooToScreen();
            }
        }
    }
}
