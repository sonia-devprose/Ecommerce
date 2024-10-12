using System;

namespace Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {

            // short data type used for product ID (small integer)

            short product_id = 23489;
            Console.WriteLine("The product has an ID: " + product_id);

            // int data type used for inventory count (whole number)
            int inventory_count = 230;
            Console.WriteLine("The total number of inventory: " + inventory_count);

            // long data type used for total items sold (large integer)
            long total_itemsSold = 45678;
            Console.WriteLine("Total items sold: " + total_itemsSold);

            // float data type used for product price (decimal value with less precision)
            float product_price = 124.99f;
            Console.WriteLine("The price of this product is: " + product_price);

            // double data type used for total revenue (higher precision for financial calculations)
            double total_revenue = total_itemsSold * product_price;
            Console.WriteLine("The total revenue: $" + total_revenue);

        }




    }



}