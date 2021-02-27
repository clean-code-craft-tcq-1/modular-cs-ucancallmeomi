using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ColorCodeTests
    {
        public static void PerformColorFromPairNumberTests()
        {
            int pairNumber = 4;
            ColorPairExecutionLogic testPair1 = ColorPairExecutionLogic.GetColorFromPairNumber(pairNumber);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.Brown);
            pairNumber = 5;
            testPair1 = ColorPairExecutionLogic.GetColorFromPairNumber(pairNumber);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.SlateGray);
            pairNumber = 23;
            testPair1 = ColorPairExecutionLogic.GetColorFromPairNumber(pairNumber);
            Debug.Assert(testPair1.majorColor == Color.Violet);
            Debug.Assert(testPair1.minorColor == Color.Green);
        }

        public static void PerformPairNumberFromColorTests()
        {
            ColorPairExecutionLogic testPair2 = new ColorPairExecutionLogic() { majorColor = Color.Yellow, minorColor = Color.Green };
            int pairNumber = ColorPairExecutionLogic.GetPairNumberFromColor(testPair2);
            Debug.Assert(pairNumber == 18);
            testPair2 = new ColorPairExecutionLogic() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = ColorPairExecutionLogic.GetPairNumberFromColor(testPair2);
            Debug.Assert(pairNumber == 6);
        }
    }
}
