using System.Drawing;


namespace BestRedactor.Logics
{
    public static class Intensity
    {
        //якрость
        public static Bitmap Brightness(Bitmap image, int poz)
        {
            var   N     = poz - 100; //кол-во процентов
            var   total = (Bitmap)image.Clone();
            var   rgb   = new PixelPoint();
            Color c;

            for (var y = 0; y < total.Height; y++)
            for (var x = 0; x < total.Width; x++)
            {
                c     = total.GetPixel(x, y);
                rgb.R = c.R + N * 128 / 100;
                rgb.G = c.G + N * 128 / 100;
                rgb.B = c.B + N * 128 / 100;
                total.SetPixel(x, y, Color.FromArgb(rgb.R, rgb.G, rgb.B));
            }

            return total;
        }

        //контрастность
        public static Bitmap Contrast(Bitmap image, int poz)
        {
            var N     = poz - 100; //кол-во процентов
            var rgb   = new PixelPoint();
            var total = (Bitmap)image.Clone();

            Color c;

            for (var y = 0; y < total.Height; y++)
            for (var x = 0; x < total.Width; x++)
            {
                c = total.GetPixel(x, y);
                if (N >= 0)
                {
                    if (N == 100) N = 99;
                    rgb.R = (c.R * 100 - 128 * N) / (100 - N);
                    rgb.G = (c.G * 100 - 128 * N) / (100 - N);
                    rgb.B = (c.B * 100 - 128 * N) / (100 - N);
                }
                else
                {
                    rgb.R = (c.R * (100 + N) - 128 * N) / 100;
                    rgb.G = (c.G * (100 + N) - 128 * N) / 100;
                    rgb.B = (c.B * (100 + N) - 128 * N) / 100;
                }

                total.SetPixel(x, y, Color.FromArgb(rgb.R, rgb.G, rgb.B));
            }

            return total;
        }
    }
}