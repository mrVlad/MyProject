using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Filter.Common.Enums;
using Filter.Common.Structures;
using Newtonsoft.Json;

namespace Filter.Logic.Helpers
{
    public class ApiHelper
    {
        private static string _getUrl(CurrencyType type, DateTime day)
        {
            var url = String.Format("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?" +
                "valcode={0}&date={1}&json", type, day.ToString("yyyyMMdd"));
            return url;
        }

        public static CurrencyRate _currencyRate(CurrencyType type, DateTime day)
        {
            using (var client = new WebClient())
            {
                var jsonData = client.DownloadData(_getUrl(type, day));
                //return JsonConvert.DeserializeObject<List<CurrencyRate>>(Encoding.UTF8.GetString(jsonData))[0];    
                return JsonConvert.DeserializeObject<List<CurrencyRate>>(Encoding.UTF8.GetString(jsonData))[0];
            }
        }

    }
}