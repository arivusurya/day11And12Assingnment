using System;
using System.Collections.Generic;


namespace StockManagement{

    public class StockPortfolio{
        public List<Stock> stocks ;

        public void eachvalue(){
            foreach(Stock s in stocks){
                Console.WriteLine("The stock for {0} is {1}",s.Name,s.getvalue());
            }
        }

        public void ToatlStocks(){
            int ToatlStocks = 0;
            foreach(Stock s in stocks){
                ToatlStocks += s.getvalue();
            }
            Console.WriteLine("Total Stock value is {0}",ToatlStocks);

        }

        
    }

    public class Stock{
        public string Name;
        public int noOfShares;
        public int price;

        public int getvalue(){
            return noOfShares*price;
        }
    }
}