using System;
using System.Collections.Generic;
using System.IO;

namespace Filter.Logic.Helpers
{
    public static class SerializeHelper
    {
        public static List<double> ReadFromCsv(string path)
        {
            var data = new List<double>();
            using (TextReader textReader = File.OpenText(path))
            {
                var csv = new CsvHelper.CsvReader(textReader);
                csv.Configuration.HasHeaderRecord = false;
                while (csv.Read())
                {
                    string value;
                    for (int i = 0; csv.TryGetField(i, out value); i++)
                    {
                        data.Add(Convert.ToDouble(value));
                    }
                }
            }
            return data;
        }

        public static void WriteToCsv(List<double> data, string path)
        {
            using (TextWriter textWriter = File.CreateText(path))
            {
                var csv = new CsvHelper.CsvWriter(textWriter);
                foreach (var item in data)
                {
                    csv.WriteRecord(item);
                }
            }
        }

    }
}