using System.Drawing;
using NUnit.Framework;
using BestRedactor.Logics;

namespace BestRedactor.Tests
{
    [TestFixture]
    public class PrecisionTests
    {
        // Размытие
        [Test]
        public void NegativeNullBlurTest()
        {
            Bitmap expected = null;
            Assert.Throws<System.ArgumentNullException>(() => Precision.Blur(expected));
        }

        [Test]
        public void NegativeOutOfRangeBlurTest()
        {
            Bitmap expected = new Bitmap(7680, 4320);
            Assert.Throws<System.ArgumentOutOfRangeException>(() => Precision.Blur(expected));
        }

        //  Резкость
        [Test]
        public void NegativeNullSharpnessTest()
        {
            Bitmap expected = null;
            Assert.Throws<System.ArgumentNullException>(() => Precision.Sharpness(expected));
        }

        [Test]
        public void NegativeOutOfRangeSharpnessTest()
        {
            Bitmap expected = new Bitmap(7680, 4320);
            Assert.Throws<System.ArgumentOutOfRangeException>(() => Precision.Sharpness(expected));
        }
    }
}