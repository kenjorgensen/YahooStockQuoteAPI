using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooStockQuoteAPI.Types {

    public class YahooStockQuoteResponse {
        public YahooStockQuoteQuery query { get; set; }
    }

    public class YahooStockQuoteQuery {
        public int count { get; set; }
        public string created { get; set; }
        public string lang { get; set; }
        public YahooStockQuoteResults results { get; set; }
    }
}
