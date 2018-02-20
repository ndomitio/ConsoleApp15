using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
   public class BeachDestination : Beach
    {
        //fields
        //properties
        //constructors
        public BeachDestination()
        {

        }

        public BeachDestination(string Eyecolor)
        {
            this.EyeColor = Eyecolor;
        }

        //methods

        public override int ChangeEyeColorToInt()
        { int eyeNumber = base.ChangeEyeColorToInt();
            ChangeIntToBeach(eyeNumber);
                return 0;
        }

        public void ChangeIntToBeach(int eyeNumber)
        {
            if (eyeNumber == 1)
                Console.WriteLine( "Venice");
            if (eyeNumber == 2)
                Console.WriteLine("Redondo");
            if (eyeNumber == 3)
                Console.WriteLine("Jersey Shore");
            if (eyeNumber == 4)
                Console.WriteLine("Champagne");
            if (eyeNumber == 5)
                Console.WriteLine("Bondi");
            
        }
    }
}
