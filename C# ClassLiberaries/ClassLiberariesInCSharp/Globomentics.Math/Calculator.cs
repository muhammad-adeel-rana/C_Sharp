using System;

namespace Globomentics.Math
{
    public static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static string AsHex(int a)
        {
            var hex = a.ToString("X");
#if NET9_0
            return $"{hex} from dotnet9.0";
#elif NET472
            return $"{hex} from dotnet4.7.2";
#elif NETSTANDARD2_0
            return $"{hex} from dotnet6.0";
#else
//#error No TFM-Specific Code has been implemented
    throw new System.PlatformNotSupportedException();
#endif
        }

        public static bool IsWriteAsHexSupported
        {
            get
            {
#if NET9_0 || NET472 || NETSTANDARD2_0
                return true;
#else
                return false;
#endif
            }
        }

        internal static void SomeMethod()
        {

        }
    }
}