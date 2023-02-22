using System;


namespace StockManagement{

    public class Program{
        public static void Main(string[] args)
        {
            ReadStocks obj = new ReadStocks();
            string Path = "/home/arivusurya/dailyclass/stockManagemant/Stocks.json";
            StockPortfolio data = obj.read(Path);
           data.eachvalue();
           data.ToatlStocks();
           
        }

    }

}