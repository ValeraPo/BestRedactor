using System.Drawing;
using NUnit.Framework;
using BestRedactor.Logics;

namespace BestRedactor.Tests
{
    [TestFixture]
    public class IntesityTests
    {
        // Яркость
        public static Bitmap BrightnessMockOutputData(Tests.Bitmaps bm)
        {
            Bitmap res = new Bitmap(6, 6);
            switch (bm)
            {
                case Tests.Bitmaps.black:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(255, 128,128,128));
                    break;
                };
                case Tests.Bitmaps.white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(127,127,127));
                    break;
                };  
                case Tests.Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(36,136,0));
                    break;
                };
                case Tests.Bitmaps.black_white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 3) 
                            res.SetPixel(x, y, Color.FromArgb(64, 64, 64));
                        else
                            res.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_horizontal:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( x < 2) 
                            res.SetPixel(x, y, Color.FromArgb(255, 64, 64));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(64, 255, 64));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(64, 64, 255));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_vertical:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 2) 
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
                        else if (y < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                    }
                    break;
                };
            }

            return res;
        }
        [TestCase(Tests.Bitmaps.black, 200)]
        [TestCase(Tests.Bitmaps.white, 0)]
        [TestCase(Tests.Bitmaps.one_color, 50)]
        [TestCase(Tests.Bitmaps.black_white, 150)]
        [TestCase(Tests.Bitmaps.rgb_horizontal, 150)]
        [TestCase(Tests.Bitmaps.rgb_vertical, 100)]

        public void BrightnessTest(Tests.Bitmaps bm, int poz)
        {
            Bitmap input = Tests.MockInputData(bm);
            Bitmap expected = BrightnessMockOutputData(bm);
            Bitmap actual = Intensity.Brightness(input, poz);
            Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));
        }

        [Test]
        public void NegativeNullBrightnessTest()
        {
            Bitmap expected = null;
            Assert.Throws<System.ArgumentNullException>(() => Intensity.Brightness(expected, 100));
        }

        [Test]
        public void NegativeOutOfRangeBrightnessTest()
        {
            Bitmap expected = new Bitmap(7680, 4320);
            Assert.Throws<System.ArgumentOutOfRangeException>(() => Intensity.Brightness(expected, 100));
        }

        //  Контрастность
        public static Bitmap ContrastMockOutputData(Tests.Bitmaps bm)
        {
            Bitmap res = new Bitmap(6, 6);
            switch (bm)
            {
                case Tests.Bitmaps.black:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(255, 0,0,0));
                    break;
                };
                case Tests.Bitmaps.white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(128,128,128));
                    break;
                };  
                case Tests.Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(114,164,94));
                    break;
                };
                case Tests.Bitmaps.black_white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 3) 
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        else
                            res.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_horizontal:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( x < 2) 
                            res.SetPixel(x, y, Color.FromArgb(255, 0, 0));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 255, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 255));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_vertical:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 2) 
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
                        else if (y < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                    }
                    break;
                };
            }

            return res;
        }

        [TestCase(Tests.Bitmaps.black, 200)]
        [TestCase(Tests.Bitmaps.white, 0)]
        [TestCase(Tests.Bitmaps.one_color, 50)]
        [TestCase(Tests.Bitmaps.black_white, 150)]
        [TestCase(Tests.Bitmaps.rgb_horizontal, 150)]
        [TestCase(Tests.Bitmaps.rgb_vertical, 100)]

        public void ContrastTest(Tests.Bitmaps bm, int poz)
        {
            Bitmap input = Tests.MockInputData(bm);
            Bitmap expected = ContrastMockOutputData(bm);
            Bitmap actual = Intensity.Contrast(input, poz);
            Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));
        }

        [Test]
        public void NegativeNullContrastTest()
        {
            Bitmap expected = null;
            Assert.Throws<System.ArgumentNullException>(() => Intensity.Contrast(expected, 100));
        }

        [Test]
        public void NegativeOutOfRangeContrastTest()
        {
            Bitmap expected = new Bitmap(7680, 4320);
            Assert.Throws<System.ArgumentOutOfRangeException>(() => Intensity.Contrast(expected, 100));
        }
    }
}