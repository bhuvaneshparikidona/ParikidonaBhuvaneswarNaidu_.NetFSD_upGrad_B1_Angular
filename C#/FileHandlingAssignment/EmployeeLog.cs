using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandlingAssignment
{

    class EmployeeLog
    {
        static string filePath = "D:\\C#\\File Handling\\employee_log.txt";

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Login Entry");
                Console.WriteLine("2. Update Logout Time");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddLogin();
                        break;
                    case 2:
                        UpdateLogout();
                        break;
                    case 3:
                        return;
                }
            }
        }

        static void AddLogin()
        {
            try
            {
                Console.Write("Enter Employee ID: ");
                string id = Console.ReadLine();

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                string loginTime = DateTime.Now.ToString();

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{id}|{name}|{loginTime}|");
                }

                Console.WriteLine("Login recorded!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void UpdateLogout()
        {
            try
            {
                Console.Write("Enter Employee ID: ");
                string id = Console.ReadLine();

                List<string> lines = new List<string>(File.ReadAllLines(filePath));

                for (int i = 0; i < lines.Count; i++)
                {
                    string[] parts = lines[i].Split('|');

                    if (parts[0] == id && parts[3] == "")
                    {
                        parts[3] = DateTime.Now.ToString();
                        lines[i] = string.Join("|", parts);
                        break;
                    }
                }

                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Logout updated!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
