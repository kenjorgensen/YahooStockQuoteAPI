using System;

namespace YahooStockQuoteAPI.Types {
    public class YahooStockQuoteResults {
        public YahooStockQuoteResult quote { get; set; }
    }

    public class YahooStockQuoteResult {
        public string symbol { get; set; }
        public double? Ask { get; set; }
        public double? AverageDailyVolume { get; set; }
        public double? Bid { get; set; }
        public string AskRealtime { get; set; }
        public string BidRealtime { get; set; }
        public double? BookValue { get; set; }
        public string Change_PercentChange { get; set; }
        public double? Change { get; set; }
        public string Commission { get; set; }
        public string Currency { get; set; }
        public string ChangeRealtime { get; set; }
        public string AfterHoursChangeRealtime { get; set; }
        public double? DividendShare { get; set; }
        public DateTime LastTradeDate { get; set; }
        public DateTime? TradeDate { get; set; }
        public double? EarningsShare { get; set; }
        public string ErrorIndicationreturnedforsymbolchangedinvalid { get; set; }
        public double? EPSEstimateCurrentYear { get; set; }
        public double? EPSEstimateNextYear { get; set; }
        public double? EPSEstimateNextQuarter { get; set; }
        public double? DaysLow { get; set; }
        public double? DaysHigh { get; set; }
        public double? YearLow { get; set; }
        public double? YearHigh { get; set; }
        public string HoldingsGainPercent { get; set; }
        public double? AnnualizedGain { get; set; }
        public double? HoldingsGain { get; set; }
        public double? HoldingsGainPercentRealtime { get; set; }
        public double? HoldingsGainRealtime { get; set; }
        public string MoreInfo { get; set; }
        public double? OrderBookRealtime { get; set; }
        public string MarketCapitalization { get; set; }
        public string MarketCapRealtime { get; set; }
        public string EBITDA { get; set; }
        public double? ChangeFromYearLow { get; set; }
        public string PercentChangeFromYearLow { get; set; }
        public double? LastTradeRealtimeWithTime { get; set; }
        public double? ChangePercentRealtime { get; set; }
        public double? ChangeFromYearHigh { get; set; }
        public string PercebtChangeFromYearHigh { get; set; }
        public string LastTradeWithTime { get; set; }
        public double? LastTradePriceOnly { get; set; }
        public double? HighLimit { get; set; }
        public double? LowLimit { get; set; }
        public string DaysRange { get; set; }
        public double? DaysRangeRealtime { get; set; }
        public double? FiftydayMovingAverage { get; set; }
        public double? TwoHundreddayMovingAverage { get; set; }
        public double? ChangeFromTwoHundreddayMovingAverage { get; set; }
        public string PercentChangeFromTwoHundreddayMovingAverage { get; set; }
        public double? ChangeFromFiftydayMovingAverage { get; set; }
        public string PercentChangeFromFiftydayMovingAverage { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public double? Open { get; set; }
        public double? PreviousClose { get; set; }
        public double? PricePaid { get; set; }
        public string ChangeinPercent { get; set; }
        public double? PriceSales { get; set; }
        public double? PriceBook { get; set; }
        public DateTime? ExDividendDate { get; set; }
        public double? PERatio { get; set; }
        public DateTime? DividendPayDate { get; set; }
        public double? PERatioRealtime { get; set; }
        public double? PEGRatio { get; set; }
        public double? PriceEPSEstimateCurrentYear { get; set; }
        public double? PriceEPSEstimateNextYear { get; set; }
        public string Symbol { get; set; }
        public int? SharesOwned { get; set; }
        public double? ShortRatio { get; set; }
        public string LastTradeTime { get; set; }
        public double? TickerTrend { get; set; }
        public double? OneyrTargetPrice { get; set; }
        public double? Volume { get; set; }
        public double? HoldingsValue { get; set; }
        public double? HoldingsValueRealtime { get; set; }
        public string YearRange { get; set; }
        public double? DaysValueChange { get; set; }
        public double? DaysValueChangeRealtime { get; set; }
        public string StockExchange { get; set; }
        public double? DividendYield { get; set; }
        public string PercentChange { get; set; }
    }
}