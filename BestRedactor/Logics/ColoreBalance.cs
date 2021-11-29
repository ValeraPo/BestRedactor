using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestRedactor.Logics
{
    public class ColorBalance
    {
        //цветовой баланс R
        public static uint Change_R(uint point, int poz, int lenght)
        {
            PixelPoint pixel = new PixelPoint();

            int N = (100 / lenght) * poz; //кол-во процентов

            pixel.R = (int)(((point & 0x00FF0000) >> 16) + N * 128 / 100);
            pixel.G = (int)((point & 0x0000FF00) >> 8);
            pixel.B = (int)(point & 0x000000FF);

            point = 0xFF000000 | ((uint)pixel.R << 16) | ((uint)pixel.G << 8) | ((uint)pixel.B);

            return point;
        }

        //цветовой баланс G
        public static uint Change_G(uint point, int poz, int lenght)
        {
            PixelPoint pixel = new PixelPoint();


            int N = (100 / lenght) * poz; //кол-во процентов

            pixel.R = (int)((point & 0x00FF0000) >> 16);
            pixel.G = (int)(((point & 0x0000FF00) >> 8) + N * 128 / 100);
            pixel.B = (int)(point & 0x000000FF);

            point = 0xFF000000 | ((uint)pixel.R << 16) | ((uint)pixel.G << 8) | ((uint)pixel.B);

            return point;
        }

        //цветовой баланс B
        public static uint Change_B(uint point, int poz, int lenght)
        {
            PixelPoint pixel = new PixelPoint();

            int N = (100 / lenght) * poz; //кол-во процентов

            pixel.R = (int)((point & 0x00FF0000) >> 16);
            pixel.G = (int)((point & 0x0000FF00) >> 8);
            pixel.B = (int)((point & 0x000000FF) + N * 128 / 100);

            point = 0xFF000000 | ((uint)pixel.R << 16) | ((uint)pixel.G << 8) | ((uint)pixel.B);

            return point;
        }

    }
}
