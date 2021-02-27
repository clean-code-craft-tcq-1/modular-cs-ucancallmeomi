using System;

namespace TelCo.ColorCoder
{
    class ColorPairExecutionLogic : ColorPairMapper
    {
        public static ColorPairExecutionLogic GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = colorMapMinor.Length;
            int majorSize = colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            ColorPairExecutionLogic pair = new ColorPairExecutionLogic()
            {
                majorColor = colorMapMajor[majorIndex], minorColor = colorMapMinor[minorIndex]
            };
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, pair);
            return pair;
        }
        public static int GetPairNumberFromColor(ColorPairExecutionLogic pair)
        {
            int majorIndex = getMajorColorIndex(pair);
            int minorIndex = getMinorColorIndex(pair);

            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", pair, (majorIndex * colorMapMinor.Length) + (minorIndex + 1));
            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
