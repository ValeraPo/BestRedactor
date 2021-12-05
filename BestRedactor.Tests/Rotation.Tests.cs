using System.Drawing;
using NUnit.Framework;
using BestRedactor.Logics;

namespace BestRedactor.Tests
{
    [TestFixture]
    public class RotationTests
    {
        // Вертикальное отражение 
        public static Bitmap VerticalReflectionMockOutputData(Tests.Bitmaps bm)
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
                        res.SetPixel(x, y, Color.FromArgb(255,255,255));
                    break;
                };  
                case Tests.Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(100,200,60));
                    break;
                };
                case Tests.Bitmaps.black_white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y > 2) 
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
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_vertical:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 2) 
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                        else if (y < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
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
        public void VerticalReflectionTest(Tests.Bitmaps bm)
        {
            Bitmap input = Tests.MockInputData(bm);
            Bitmap expected = VerticalReflectionMockOutputData(bm);
            Bitmap actual = Rotation.VerticalReflection(input);
            Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));
        }
        [Test]
        public void NegativeNullVerticalReflectionTest()
        {
            Bitmap expected = null;
            Assert.Throws<System.ArgumentNullException>(() => Rotation.VerticalReflection(expected));
        }
        [Test]
        public void NegativeOutOfRangeRgbVerticalReflectionTest()
        {
            Bitmap expected = new Bitmap(7680, 4320);
            Assert.Throws<System.ArgumentOutOfRangeException>(() => Rotation.VerticalReflection(expected));
        }
        
        // Горизонтальное отражение
        public static Bitmap HorizontalReflectionMockOutputData(Tests.Bitmaps bm)
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
                        res.SetPixel(x, y, Color.FromArgb(255,255,255));
                    break;
                };  
                case Tests.Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(100,200,60));
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
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
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
         [TestCase(Tests.Bitmaps.black)]
         [TestCase(Tests.Bitmaps.white)]
         [TestCase(Tests.Bitmaps.one_color)]
         [TestCase(Tests.Bitmaps.black_white)]
         [TestCase(Tests.Bitmaps.rgb_horizontal)]
         [TestCase(Tests.Bitmaps.rgb_vertical)]
         public void HorizontalReflectionTest(Tests.Bitmaps bm)
         {
             Bitmap input = Tests.MockInputData(bm);
             Bitmap expected = HorizontalReflectionMockOutputData(bm);
             Bitmap actual = Rotation.HorizontalReflection(input);
             Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));
         }
         [Test]
         public void NegativeNullHorizontalReflectionTest()
         {
             Bitmap expected = null;
             Assert.Throws<System.ArgumentNullException>(() => Rotation.HorizontalReflection(expected));
         }
         [Test]
         public void NegativeOutOfRangeRgbHorizontalReflectionTest()
         {
             Bitmap expected = new Bitmap(7680, 4320);
             Assert.Throws<System.ArgumentOutOfRangeException>(() => Rotation.HorizontalReflection(expected));
         }
         // Поворот на произвольный угол
         // 0 
         public static Bitmap PictureRotationBy0MockOutputData(Tests.Bitmaps bm)
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
                        res.SetPixel(x, y, Color.FromArgb(255,255,255));
                    break;
                };  
                case Tests.Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(100,200,60));
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
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
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
         [TestCase(Tests.Bitmaps.black)]
         [TestCase(Tests.Bitmaps.white)]
         [TestCase(Tests.Bitmaps.one_color)]
         [TestCase(Tests.Bitmaps.black_white)]
         [TestCase(Tests.Bitmaps.rgb_horizontal)]
         [TestCase(Tests.Bitmaps.rgb_vertical)]
         public void PictureRotationBy0Test(Tests.Bitmaps bm)
         {
             Bitmap input = Tests.MockInputData(bm);
             Bitmap expected = PictureRotationBy0MockOutputData(bm);
             Bitmap actual = Rotation.PictureRotationBy(input, 0);
             Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));
         }
         // 90 
         public static Bitmap PictureRotationBy90MockOutputData(Tests.Bitmaps bm)
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
                        res.SetPixel(x, y, Color.FromArgb(255,255,255));
                    break;
                };  
                case Tests.Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(100,200,60));
                    break;
                };
                case Tests.Bitmaps.black_white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( x > 2) 
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
                        if ( y < 2) 
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
                        else if (y < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_vertical:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( x < 2) 
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
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
         public void PictureRotationBy90Test(Tests.Bitmaps bm)
         {
             Bitmap input = Tests.MockInputData(bm);
             Bitmap expected = PictureRotationBy90MockOutputData(bm);
             Bitmap actual = Rotation.PictureRotationBy(input, 90);
             Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));
         }
         //180
         public static Bitmap PictureRotationBy180MockOutputData(Tests.Bitmaps bm)
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
                        res.SetPixel(x, y, Color.FromArgb(255,255,255));
                    break;
                };  
                case Tests.Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(100,200,60));
                    break;
                };
                case Tests.Bitmaps.black_white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y > 2) 
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
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_vertical:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( y < 2) 
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                        else if (y < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
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
         public void PictureRotationBy180Test(Tests.Bitmaps bm)
         {
             Bitmap input = Tests.MockInputData(bm);
             Bitmap expected = PictureRotationBy180MockOutputData(bm);
             Bitmap actual = Rotation.PictureRotationBy(input, 180);
             Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));
         }
         //270
         public static Bitmap PictureRotationBy270MockOutputData(Tests.Bitmaps bm)
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
                        res.SetPixel(x, y, Color.FromArgb(255,255,255));
                    break;
                };  
                case Tests.Bitmaps.one_color:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                        res.SetPixel(x, y, Color.FromArgb(100,200,60));
                    break;
                };
                case Tests.Bitmaps.black_white:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( x < 3) 
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
                        if ( y < 2) 
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
                        else if (y < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
                    }
                    break;
                };
                case Tests.Bitmaps.rgb_vertical:
                {
                    for (int x = 0; x < res.Width; x++)
                    for (int y = 0; y < res.Height; y++)
                    {
                        if ( x < 2) 
                            res.SetPixel(x, y, Color.FromArgb(200, 0, 0));
                        else if (x < 4)
                            res.SetPixel(x, y, Color.FromArgb(0, 200, 0));
                        else                           
                            res.SetPixel(x, y, Color.FromArgb(0, 0, 200));
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
         public void PictureRotationBy270Test(Tests.Bitmaps bm)
         {
             Bitmap input = Tests.MockInputData(bm);
             Bitmap expected = PictureRotationBy270MockOutputData(bm);
             Bitmap actual = Rotation.PictureRotationBy(input, 270);
             Assert.AreEqual(Tests.BitmapToColor(expected), Tests.BitmapToColor(actual));
         }
         // Негативные тесты на повороты
         [Test]
         public void NegativeNullPictureRotationByTest()
         {
             Bitmap expected = null;
             Assert.Throws<System.ArgumentNullException>(() => Rotation.PictureRotationBy(expected,0));
         }
         [Test]
         public void NegativeOutOfRangeRgbPictureRotationByTest()
         {
             Bitmap expected = new Bitmap(7680, 4320);
             Assert.Throws<System.ArgumentOutOfRangeException>(() => Rotation.PictureRotationBy(expected, 0));
         }
    }
}