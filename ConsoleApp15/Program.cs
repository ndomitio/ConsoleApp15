using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            BeachDestination NewBeach = new BeachDestination(string.Empty);

            Console.WriteLine("What color are your eyes");

            NewBeach.EyeColor = Console.ReadLine();

            NewBeach.ChangeEyeColorToInt();

            Console.WriteLine("What size shoe are you?");
        


        }



    }
}
