using System;

using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            (string product, double amount, int quantity)tuple1 = ("paper", 10.5, 2);
            (string product, double amount, int quantity)tuple2 = ("pencil", 2.4, 6);
            (string product, double amount, int quantity)tuple3 = ("eraser", 1, 10);
            (string product, double amount, int quantity)tuple4 = ("ruler",3, 2);
            (string product, double amount, int quantity)tuple5 = ("clip",1, 10);


           List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
                transactions.Add(tuple1);
                transactions.Add(tuple2);
                transactions.Add(tuple3);
                transactions.Add(tuple4);
                transactions.Add(tuple5);
            
            double totalAmount = 0;
            double totalQuantity = 0;
            foreach ((string product, double amount, int quantity) t in transactions)
            {
                Console.WriteLine("Product: "+ t.product + " Amount:" + t.amount + " Quantity:" + t.quantity);
                totalAmount += t.amount;
                totalQuantity += t.quantity;
                
            }
            Console.WriteLine("Items sold today: " + totalQuantity);
            Console.WriteLine($"Total revenue:  {totalAmount:C}");



        }
    }
}
