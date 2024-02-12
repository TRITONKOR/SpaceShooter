using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceshooter
{
    namespace UI
    {
        public class Point
        {
            private int x;
            private int y;
            private char displayPixel;

            public Point(int x, int y, char displayPixel)
            {
                this.x = x;
                this.y = y;
                this.displayPixel = displayPixel;
            }

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public char DisplayPixel
            {
                get { return displayPixel; }
                set { displayPixel = value; }
            }
        }
    }

}
