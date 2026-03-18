using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentInterface
{
        abstract class Sales
        {
            public abstract double MonthlySales(double dailySales);

            public double DailySales()
            {
                return 400;
            }
        }

        interface ISales
        {
            double YearlySales(double monthlySales);
        }

        class SalesReport : Sales, ISales
        {
            public override double MonthlySales(double dailySales)
            {
                return dailySales * 30;
            }

            public double YearlySales(double monthlySales)
            {
                return monthlySales * 12;
            }
        }

        class SalesApp
        {
            static void Main()
            {
                SalesReport report = new SalesReport();

                double daily = report.DailySales();
                double monthly = report.MonthlySales(daily);
                double yearly = report.YearlySales(monthly);

                Console.WriteLine($"Daily sales: {daily}");
                Console.WriteLine($"Monthly sales: {monthly}");
                Console.WriteLine($"Annual sales: {yearly}");
            }
        }
    }

