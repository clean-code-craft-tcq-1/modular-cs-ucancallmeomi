using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    class ColorPair : Colours
    {
        internal Color majorColor, minorColor;

        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }

        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = colorMapMinor.Length;
            int majorSize = colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            ColorPair pair = new ColorPair()
            {
                majorColor = colorMapMajor[majorIndex],
                minorColor = colorMapMinor[minorIndex]
            };

            return pair;
        }


        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = getMajorIndex(pair);
            int minorIndex = getMinorIndex(pair);

            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }

        public static void ReferenceManual()
        {
            for (int i=1; i<=25; i++)
            {
                ColorPair colors = GetColorFromPairNumber(i);

                Console.WriteLine("Pair: " + i +", Colors: " + colors.majorColor + ", " + colors.minorColor );
            }
                
        }

    }
}
