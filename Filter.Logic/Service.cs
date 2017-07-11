using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filter.Common.Enums;
using Filter.Common.Structures;
using Filter.Logic.Helpers;

namespace Filter.Logic
{
    public static class Service
    {
        private static List<double> _data = new List<double>();

        public static void Load(string path)
        {
            _data.Clear();
            _data = SerializeHelper.ReadFromCsv(path);
        }

        public static IEnumerable<double> GetData()
        {
            return _data;
        }

        public static void SetData(List<double> data)
        {
            _data.Clear();
            _data = data;
        }

        public static void Save(string path)
        {
            SerializeHelper.WriteToCsv(_data, path);
        }

        public static double GetApiData(CurrencyType type, DateTime day)
        {
            return ApiHelper._currencyRate(type, day).Rate;
        } 

        public static IEnumerable<List<double>> CalcMatrix(int ammount)
        {
            var normalMatrix = new List<List<double>>();
            var startMatrix = CalcMatrixHelper.BuildStartMatrix(_data, ammount);
            for (int i = 1; i < startMatrix[0].Count; i++)
            {
                var tmp = CalcMatrixHelper.CaclSum(CalcMatrixHelper.BuildNormalMatrix(startMatrix, i)).ToList();
                normalMatrix.Add(tmp);
            }
            return normalMatrix;
        }

        public static IEnumerable<double> Coef(int ammount)
        {
            // К-ть рівнянь в системі
            var numberOfEquations = 2;
            switch (ammount)
            {
                case 0:
                    numberOfEquations = 2;
                    break;
                case 1:
                    numberOfEquations = 4;
                    break;
            }
            return CalcMatrixHelper.Gauss(CalcMatrix(ammount).ToList(), numberOfEquations).ToList();
        }

        public static double GetNextValue(List<double> coef, int ammount)
        {
            switch (ammount)
            {
                case 0:
                    return ApplicationModelHelper.CalcValue(coef, _data[_data.Count - 1], null);
                case 1:
                    return ApplicationModelHelper.CalcValue(coef, _data[_data.Count - 1], _data[_data.Count - 2]);
            }
            return 0.0;
        }

        public static int GetError(List<double> coef, double epsilon)
        {
            return ApplicationModelHelper.StandartDeviation(_data, coef, epsilon);
        }
    }
}