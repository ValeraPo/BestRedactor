using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BestRedactor.Logics
{
    public class PixelPoint
    {
        private int _r;
        private int _g;
        private int _b;
        public int R
        {
            get => _r;
            set
            {
                if (value > 255) _r = 255;
                if (value < 0) _r = 0;
            }
        }
        public int G
        {
            get => _g;
            set
            {
                if (value > 255) _g = 255;
                if (value < 0) _g = 0;
            }
        }
        public int B
        {
            get => _b;
            set
            {
                if (value > 255) _b = 255;
                if (value < 0) _b = 0;
            }
        }
    }
}
