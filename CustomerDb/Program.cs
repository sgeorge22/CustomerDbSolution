using System;

namespace CustomerDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var ord1 = new Order();
            var n = ord1.Add1(5);
            Console.WriteLine($"Add1 evaluates to {ord1.Add1(5)}.");


            var cus1 = new Customer("TQL", "Cincinnati", "OH");
            cus1.AddSales(1000);
            cus1.AddSales(4000);
            Console.WriteLine($"Customer {cus1.Name} sales are ${cus1.Sales}.");


            
           
        }
    }
}
