using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20212201_SZTF1_E72LET_Feleves
{
    internal class Pixel
    {
        int red;
        int green;
        int blue;


        public Pixel(Random rnd)

        {
            red = rnd.Next(0, 256);
            green = rnd.Next(0, 256);
            blue = rnd.Next(0, 256);
        }


        public int Red
        {
            get { return red; }

        }
        public int Green
        {
            get { return green; }

        }
        public int Blue
        {
            get { return blue; }

        }
    }
}
