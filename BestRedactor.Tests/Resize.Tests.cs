using System.Drawing;
using NUnit.Framework;
using BestRedactor.Logics;

namespace BestRedactor.Tests
{
    [TestFixture]
    public class ResizeTests
    {
        public static Bitmap ResizingMockOutputData(Tests.Bitmaps bm)
        {
            Bitmap res;
            switch (bm)
            {
                case Tests.Bitmaps.black:
                {
                    res = new Bitmap(12, 12);
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ((y < 11 && x < 11) || (x < 11 && y < 11))
                            res.SetPixel(x, y, Color.FromArgb(255, 0,0,0));
                        else if (x > 10 && y > 10)
                            res.SetPixel(x, y, Color.FromArgb(64, 0, 0, 0));
                        else res.SetPixel(x, y, Color.FromArgb(128, 0,0,0));
                    }
                    return res;
                };
                case Tests.Bitmaps.white:
                {
                    res = new Bitmap(6, 6);
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(255,255,255));
                    return res;
                };  
                case Tests.Bitmaps.one_color:
                {
                    res = new Bitmap(12, 12);
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        if ((y < 11 && x < 11) || (x < 11 && y < 11))
                            res.SetPixel(x, y, Color.FromArgb(255,100,200,60));
                        else if (x > 10 && y > 10)
                            res.SetPixel(x, y, Color.FromArgb(64, 99,199,59));
                        else res.SetPixel(x, y, Color.FromArgb(128, 99,199,59));
                    return res;
                };
                
                case Tests.Bitmaps.rgb_horizontal:
                {
                    res = new Bitmap(3, 3);
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( x < 1) 
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
                        else if (x < 2)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                    }
                    return res;
                };
            }

            res = new Bitmap(0, 0);
            return res;
        }
        
        [TestCase(Tests.Bitmaps.black, 2)]
        [TestCase(Tests.Bitmaps.white, 1)]
        [TestCase(Tests.Bitmaps.one_color, 2)]
        [TestCase(Tests.Bitmaps.rgb_horizontal, 0.5)]
        public void ResizingTest(Tests.Bitmaps bm, double coef)
        {
            Bitmap input = Tests.MockInputData(bm);
            Bitmap expected = ResizingMockOutputData(bm);
            Bitmap actual = Resize.Resizing(input, coef);
            Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));
        }

        [Test]
        public void NegativeNullResizingTest()
        {
            Bitmap expected = null;
            Assert.Throws<System.ArgumentNullException>(() => Resize.Resizing(expected, 100));
        }

        [Test]
        public void NegativeOutOfRangeResizingTest()
        {
            Bitmap expected = new Bitmap(7680, 4320);
            Assert.Throws<System.ArgumentOutOfRangeException>(() => Resize.Resizing(expected, 100));
        }
        
    }
}