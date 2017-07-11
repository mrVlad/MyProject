using System.Collections.Generic;
using System.Linq;

namespace Filter.Logic.Helpers
{
    public static class CalcMatrixHelper
    {
        public static List<List<double>> BuildStartMatrix(List<double> data, int amount)
        {
            var startMatrix = new List<List<double>>();
            switch (amount + 1)
            {
                case 1:
                    for (int i = 1; i < data.Count; i++)
                    {
                        var list = new List<double>
                        {
                            data[i],
                            1,
                            data[i - 1]
                        };
                        startMatrix.Add(list);
                    }
                    break;
                case 2:
                    for (int i = 2; i < data.Count; i++)
                    {
                        var list = new List<double>
                        {
                            data[i],
                            1,
                            data[i - 2],
                            data[i - 1],
                            data[i - 1]*data[i - 2]
                        };
                        startMatrix.Add(list);
                    }
                    break;
            }
            return startMatrix;
        }

        public static List<List<double>> BuildNormalMatrix(List<List<double>> data, int count)
        {
            return data.Select(item => item.Select(t => t*item[count]).ToList()).ToList();
        }

        public static IEnumerable<double> CaclSum(List<List<double>> data)
        {
            var sum = new List<double>();
            for (int i = 0; i < data[0].Count; i++)
            {
                sum.Add(0);
            }
            foreach (var item in data)
            {
                for (int j = 0; j < item.Count; j++)
                {
                    sum[j] += item[j];
                }
            }
            return sum;
        }

        public static double[] Gauss(List<List<double>> data, int ammount)
        {
            var a = new double[ammount, ammount];
            var b = new double[ammount];
            var x = new double[ammount];

            for (int i = 0; i < ammount; i++)
            {
                var q = 0;
                // correct 5 to 3
                for (int j = 1; j < data[0].Count; j++)
                {
                    a[i, q] = data[i][j];
                    q++;
                }
            }
            for (int i = 0; i < ammount; i++)
            {
                b[i] = data[i][0];
            }
            for (int k = 0; k < ammount - 1; k++)
            {
                for (int i = k + 1; i < ammount; i++)
                {
                    for (int j = k + 1; j < ammount; j++)
                    {
                        a[i, j] = a[i, j] - a[k, j] * (a[i, k] / a[k, k]);
                    }
                    b[i] = b[i] - b[k] * a[i, k] / a[k, k];
                }
            }
            for (int k = ammount - 1; k >= 0; k--)
            {
                var s = 0.0;
                for (int j = k + 1; j < ammount; j++)
                    s = s + a[k, j] * x[j];
                x[k] = (b[k] - s) / a[k, k];
            }
            return x;
        }

    }
}