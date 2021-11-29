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
        public int R
        {
            get => R;
            set
            {
                if (value > 255) R = 255;
                if (value < 0) R = 0;
            }
        }
        public int G
        {
            get => G;
            set
            {
                if (value > 255) G = 255;
                if (value < 0) G = 0;
            }
        }
        public int B
        {
            get => B;
            set
            {
                if (value > 255) B = 255;
                if (value < 0) B = 0;
            }
        }
    }
}
