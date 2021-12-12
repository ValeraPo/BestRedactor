using System.Drawing;
using NUnit.Framework;
using BestRedactor.Logics;

namespace BestRedactor.Tests
{
    [TestFixture]
    public class ColorBalanceTests
    {
        // Цветовой баланс
        public static Bitmap RgbBalanceMockOutputData(Tests.Bitmaps bm)
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
                        res.SetPixel(x, y, Color.FromArgb(255,255,255));
                    break;
                };  
                case Tests.Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(100,255,60));
                    break;
                };
                case Tests.Bitmaps.black_white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 3) 
                            res.SetPixel(x, y, Color.FromArgb(128, 128, 128));
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
                            res.SetPixel(x, y, Color.FromArgb(255, 0, 128));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(128, 200, 128));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(128, 0, 255));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_vertical:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 2) 
                            res.SetPixel(x, y, Color.FromArgb(255, 0, 128));
                        else if (y < 4)
                            res.SetPixel(x, y, Color.FromArgb(128, 200, 128));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(128, 0, 255));
                    }
                    break;
                };
            }
            return res;
        }

        [TestCase(Tests.Bitmaps.black, 199, 199, 199)]
        [TestCase(Tests.Bitmaps.white, 200, 200, 200)]
        [TestCase(Tests.Bitmaps.one_color, 99, 199, 99)]
        [TestCase(Tests.Bitmaps.black_white, 199, 199, 199)]
        [TestCase(Tests.Bitmaps.rgb_horizontal, 199, 99, 199)]
        [TestCase(Tests.Bitmaps.rgb_vertical, 199, 99, 199)]

        public void RgbBalanceTest(Tests.Bitmaps bm, int r, int g, int b)
        {
            Bitmap input = Tests.MockInputData(bm);
            Bitmap expected = RgbBalanceMockOutputData(bm);
            Bitmap actual = ColorBalance.RgbBalance(input, r, g, b);
            Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));
        }
        [Test]
        public void NegativeNullRgbBalanceTest()
        {
            Bitmap expected = null;
            Assert.Throws<System.ArgumentNullException>(() => ColorBalance.RgbBalance(expected, 99, 99,99));
        }
        [Test]
        public void NegativeOutOfRangeRgbBalanceTest()
        {
            Bitmap expected = new Bitmap(7680, 4320);
            Assert.Throws<System.ArgumentOutOfRangeException>(() => ColorBalance.RgbBalance(expected, 99, 99, 99));
        }
        //  Чернобелый фильтр
        public static Bitmap ToGrayScaleMockOutputData(Tests.Bitmaps bm)
        {
            Bitmap res = new Bitmap(6, 6);
            switch (bm)
            {
                case Tests.Bitmaps.black:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(0,0,0));
                    break;
                };
                case Tests.Bitmaps.white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(255,255,255));
                    break;
                };  
                case Tests.Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(154,154,154));
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
                            res.SetPixel(x, y, Color.FromArgb(60, 60, 60));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(117, 117, 117));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(23, 23, 23));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_vertical:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 2) 
                            res.SetPixel(x, y, Color.FromArgb(60, 60, 60));
                        else if (y < 4)
                            res.SetPixel(x, y, Color.FromArgb(117, 117, 117));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(23, 23, 23));
                    }
                    break;
                };
            }
            return res;
        }

        [TestCase(Tests.Bitmaps.black)]
        [TestCase(Tests.Bitmaps.white)]
        [TestCase(Tests.Bitmaps.one_color)]
        [TestCase(Tests.Bitmaps.black_white)]
        [TestCase(Tests.Bitmaps.rgb_horizontal)]
        [TestCase(Tests.Bitmaps.rgb_vertical)]

        public void ToGrayScaleTest(Tests.Bitmaps bm)
        {
            Bitmap input = Tests.MockInputData(bm);
            Bitmap expected = ToGrayScaleMockOutputData(bm);
            Bitmap actual = ColorBalance.ToGrayScale(input);
            Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));

        }
        [Test]
        public void NegativeNullToGrayScaleTest()
        {
            Bitmap expected = null;
            Assert.Throws<System.ArgumentNullException>(() => ColorBalance.ToGrayScale(expected));
        }
        [Test]
        public void NegativeOutOfRangeRgbToGrayScaleTest()
        {
            Bitmap expected = new Bitmap(7680, 4320);
            Assert.Throws<System.ArgumentOutOfRangeException>(() => ColorBalance.ToGrayScale(expected));
        }
        // Инверсия
        public static Bitmap IverseColorMockOutputData(Tests.Bitmaps bm)
        {
            Bitmap res = new Bitmap(6, 6);
            switch (bm)
            {
                case Tests.Bitmaps.black:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(255, 255,255,255));
                    break;
                };
                case Tests.Bitmaps.white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(0,0,0));
                    break;
                };  
                case Tests.Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(155,55,195));
                    break;
                };
                case Tests.Bitmaps.black_white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 3) 
                            res.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        else
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_horizontal:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( x < 2) 
                            res.SetPixel(x, y, Color.FromArgb(55, 255, 255));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(255, 55, 255));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(255, 255, 55));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_vertical:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 2) 
                            res.SetPixel(x, y, Color.FromArgb(55, 255, 255));
                        else if (y < 4)
                            res.SetPixel(x, y, Color.FromArgb(255, 55, 255));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(255, 255, 55));
                    }
                    break;
                };
            }
            return res;
        }

        [TestCase(Tests.Bitmaps.black)]
        [TestCase(Tests.Bitmaps.white)]
        [TestCase(Tests.Bitmaps.one_color)]
        [TestCase(Tests.Bitmaps.black_white)]
        [TestCase(Tests.Bitmaps.rgb_horizontal)]
        [TestCase(Tests.Bitmaps.rgb_vertical)]

        public void IverseColorTest(Tests.Bitmaps bm)
        {
            Bitmap input = Tests.MockInputData(bm);
            Bitmap expected = IverseColorMockOutputData(bm);
            Bitmap actual = ColorBalance.InverseColor(input);
            Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));

        }
        [Test]
        public void NegativeNullIverseColorTest()
        {
            Bitmap expected = null;
            Assert.Throws<System.ArgumentNullException>(() => ColorBalance.InverseColor(expected));
        }
        [Test]
        public void NegativeOutOfRangeIverseColorTest()
        {
            Bitmap expected = new Bitmap(7680, 4320);
            Assert.Throws<System.ArgumentOutOfRangeException>(() => ColorBalance.InverseColor(expected));
        }
        // Сепия
        public static Bitmap SepiaMockOutputData(Tests.Bitmaps bm)
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
                        res.SetPixel(x, y, Color.FromArgb(255,255,238));
                    break;
                };  
                case Tests.Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(204,182,141));
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
                            res.SetPixel(x, y, Color.FromArgb(255, 255, 238));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_horizontal:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( x < 2) 
                            res.SetPixel(x, y, Color.FromArgb(78, 69, 54));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(153, 137, 106));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(37, 33, 26));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_vertical:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 2) 
                            res.SetPixel(x, y, Color.FromArgb(78, 69, 54));
                        else if (y < 4)
                            res.SetPixel(x, y, Color.FromArgb(153, 137, 106));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(37, 33, 26));
                    }
                    break;
                };
            }
            return res;
        }

        [TestCase(Tests.Bitmaps.black)]
        [TestCase(Tests.Bitmaps.white)]
        [TestCase(Tests.Bitmaps.one_color)]
        [TestCase(Tests.Bitmaps.black_white)]
        [TestCase(Tests.Bitmaps.rgb_horizontal)]
        [TestCase(Tests.Bitmaps.rgb_vertical)]
        public void SepiaTest(Tests.Bitmaps bm)
        {
            Bitmap input = Tests.MockInputData(bm);
            Bitmap expected = SepiaMockOutputData(bm);
            Bitmap actual = ColorBalance.Sepia(input);
            Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));

        }
        [Test]
        public void NegativeNullSepiaTest()
        {
            Bitmap expected = null;
            Assert.Throws<System.ArgumentNullException>(() => ColorBalance.Sepia(expected));
        }
        [Test]
        public void NegativeOutOfRangeSepiaTest()
        {
            Bitmap expected = new Bitmap(7680, 4320);
            Assert.Throws<System.ArgumentOutOfRangeException>(() => ColorBalance.Sepia(expected));
        }
    }
}