using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooStockQuoteConsole {
    public class Program {
        static void Main( string[] args ) {
            YahooStockQuoteAPI.YahooStockQuoteStream stream = new YahooStockQuoteAPI.YahooStockQuoteStream();

            var request = stream.Update("AMD");
        }
    }
}
