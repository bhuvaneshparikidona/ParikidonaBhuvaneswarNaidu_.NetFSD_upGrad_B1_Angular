using System;
using System.Collections.Generic;
using System.Text;

class ShopkeeperSalesCalculator
{
    public void Run()
    {
        double total = 0;
        double[] price = { 0, 22.5, 44.50, 9.98 };

        while (true)
        {
            int product = Convert.ToInt32(Console.ReadLine());
            if (product == 0) break;

            int quantity = Convert.ToInt32(Console.ReadLine());
            total += price[product] * quantity;
        }

        Console.WriteLine(total);
    }
}
