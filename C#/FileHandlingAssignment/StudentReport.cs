using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandlingAssignment
{

    class StudentReport
    {
        static void Main()
        {
            Console.WriteLine("1. Create Report");
            Console.WriteLine("2. Read Report");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                CreateReport();
            else
                ReadReport();
        }

        static void CreateReport()
        {
            try
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Roll Number: ");
                string roll = Console.ReadLine();

                Console.Write("Marks 1: ");
                int m1 = int.Parse(Console.ReadLine());

                Console.Write("Marks 2: ");
                int m2 = int.Parse(Console.ReadLine());

                Console.Write("Marks 3: ");
                int m3 = int.Parse(Console.ReadLine());

                int total = m1 + m2 + m3;
                double avg = total / 3.0;

                string grade = avg >= 80 ? "A" :
                               avg >= 60 ? "B" :
                               avg >= 40 ? "C" : "Fail";

                string content = $"Student Name: {name}\n" +
                                 $"Roll Number: {roll}\n" +
                                 $"Marks: {m1}, {m2}, {m3}\n" +
                                 $"Total: {total}\n" +
                                 $"Average: {avg}\n" +
                                 $"Grade: {grade}";

                File.WriteAllText($"{roll}.txt", content);

                Console.WriteLine("Report saved!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ReadReport()
        {
            try
            {
                Console.Write("Enter Roll Number: ");
                string roll = Console.ReadLine();

                string content = File.ReadAllText($"{roll}.txt");
                Console.WriteLine("\n" + content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Report not found!");
            }
        }
    }
}
