using System;

namespace Unit1
{
    internal class Program
    {
        
        
        
        public static void Main(string[] args)
        {
            int maxSoda = 100;
            int maxChips = 40;
            int maxCandy = 60;
            
            int minSoda = 60;
            int minChips = 20;
            int minCandy = 40;
            
            maxSoda = ReturnMaxStock("Soda", stockvarmax: maxSoda, stockvarmin: minSoda);
            maxCandy = ReturnMaxStock(stockname: "Candy", stockvarmax: maxCandy, stockvarmin: minCandy);
            maxChips = ReturnMaxStock(stockname: "Chips", stockvarmax: maxChips, stockvarmin: minChips);
            
            Console.WriteLine("");
            Console.WriteLine("");
            
            if (maxCandy <= minCandy) { Console.WriteLine("Before you leave work today, call Hershey. We need more candy"); }
            if (maxChips <= minChips) { Console.WriteLine("Before you leave work today, call Lays. We need more chips"); }
            if (maxSoda <= minSoda) { Console.WriteLine("Before you leave work today, call Pepsi. We need more pop");}
        }

        public static int ReturnMaxStock(string stockname, int stockvarmax, int stockvarmin)
        {
            Console.WriteLine("");
            Console.WriteLine("how many " + stockname + "(s) have been purchased?");
            
            int currentStock = Convert.ToInt32(Console.ReadLine());
            if (currentStock >= stockvarmax)
            {
                Console.Error.WriteLine("impossible try again! >:(");
                return stockvarmax;
            }
            else if ((stockvarmax - currentStock) < stockvarmin)
            {
                Console.WriteLine("We need to restock!!! " + (stockvarmax - currentStock) + stockname + "(s) is left");
                return (stockvarmax - currentStock);
            }
            else
            {
                Console.WriteLine("No need for alarm, we have enough " + stockname + "(" + (stockvarmax - currentStock) + ")");
                return (stockvarmax - currentStock);
            }
        }
        
    }
}