using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public abstract class Beach
    {
        //fields

        private string eyeColor;

        //properties

        public string EyeColor { get; set; }
        //constructors

        public Beach()
        { }

        //methods

        public virtual int ChangeEyeColorToInt()
        {
            Console.WriteLine("What color are your eyes?");
            
            if (EyeColor == "blue")
                return 1;
            if (EyeColor == "green")
                return 2;
            if (EyeColor == "brown")
                return 3;
            if (EyeColor == "hazel")
                return 4;
            else
                return 5;
        }
    }
}


