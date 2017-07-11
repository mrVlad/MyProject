using System;
using System.Collections.Generic;

namespace Filter.Logic.Helpers
{
    public class ApplicationModelHelper
    {
        public static int StandartDeviation(List<double> startData, List<double> coef, double epsilon)
        {
            var deviation = 0.0;
            var countSteps = 1;
            var i = 2;
            var newList = new List<double>();

            while (deviation < epsilon && (startData.Count - i - 1) >= 0)
            {
                var result = 0.0;
                switch (coef.Count)
                {
                    case 2:
                        result = coef[0] + coef[1]*startData[startData.Count - i];
                        newList.Add(result);
                        break;
                    case 4:
                        var value1 = startData[startData.Count - i];
                        var value2 = startData[startData.Count - i - 1];
                        result = coef[0] + coef[1] * value1 + coef[2] * value2 
                            + coef[3] * value1 * value2;
                        newList.Add(result);
                        break;
                }
                deviation = Math.Abs(result - startData[startData.Count - i + 1]);

                i++;
            }

            var j = 1;
            var k = 1;
            deviation = 0.0;

            while (deviation < epsilon && j < newList.Count - 1)
            {
                var result = 0.0;
                switch (coef.Count)
                {
                    case 2:
                        result = coef[0] + coef[1] * newList[j];
                        newList.Add(result);
                        break;
                    case 4:
                        var value1 = newList[j];
                        var value2 = newList[j + 1];
                        result = coef[0] + coef[1] * value1 + coef[2] * value2
                            + coef[3] * value1 * value2;
                        break;
                }
                deviation = Math.Abs(result - startData[startData.Count - k]);

                j++;
                k++;
                countSteps++;
            }

            return countSteps - 1;
        }

        public static double CalcValue(List<double> coef, double value1, double ?value2)
        {
            switch (coef.Count)
            {
                case 2:
                    return (coef[0] + coef[1]*value1);
                    break;
                case 4:
                    if (value2 != null)
                        return (coef[0] + coef[1]*value2.Value + coef[2]*value1 + coef[3]*value1*value2.Value);
                    break;
            }
            return 0.0;
        }

    }
}