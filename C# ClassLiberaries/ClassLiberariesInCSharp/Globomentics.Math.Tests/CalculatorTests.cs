using Globomentics.Math;

namespace Globomentics.Math.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void Add2PositiveNumbers()
        {
            var result = Calculator.Add(40, 2);
            Assert.That(result, Is.EqualTo(42));
        }

        [Test]
        public void AsHex_String_Test()
        {
            string hex = Calculator.AsHex(255);
#if NET9_0
             Assert.That(hex, Is.EqualTo("FF from dotnet9.0"));
#elif NET472
            Assert.That(hex, Is.EqualTo("FF from dotnet4.7.2"));
#else
#error No TFM-Specific Code has been implemented
#endif
        }

        [Test]
        public void Internal()
        {
            Calculator.SomeMethod();
        }
    }
}