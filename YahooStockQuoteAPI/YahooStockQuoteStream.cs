using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YahooStockQuoteAPI.Types;

namespace YahooStockQuoteAPI {
    public class YahooStockQuoteStream {
        private static String DEFAULT_STOCKTWITS_API = @"https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20(%22{0}%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&callback=";

        public List<YahooStockQuoteResult> Data { get; private set; }

        public YahooStockQuoteResult Update( string symbol ) {
            string urlRequest = string.Format(DEFAULT_STOCKTWITS_API, symbol);
            HttpWebRequest request = WebRequest.Create(urlRequest) as HttpWebRequest;
            using ( HttpWebResponse response = request.GetResponse() as HttpWebResponse ) {
                if ( response.StatusCode != HttpStatusCode.OK )
                    throw new Exception(String.Format(
                    "Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.StatusDescription));
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                using ( StreamReader sr = new StreamReader(response.GetResponseStream(), encode) ) {
                    string json = sr.ReadToEnd();
                    YahooStockQuoteResponse jsonResponse = JsonConvert.DeserializeObject<YahooStockQuoteResponse>(json);
                    return jsonResponse.query.results.quote;
                }
            }
        }

    }
}
