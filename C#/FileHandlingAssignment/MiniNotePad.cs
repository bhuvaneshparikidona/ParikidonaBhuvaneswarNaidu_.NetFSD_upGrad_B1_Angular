using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandlingAssignment
{
    using System;
    using System.IO;

    class MiniNotepad
    {
        static void Main()
        {
            string filePath = "note.txt";

            while (true)
            {
                Console.WriteLine("\n1. Create File");
                Console.WriteLine("2. Write");
                Console.WriteLine("3. Read");
                Console.WriteLine("4. Append");
                Console.WriteLine("5. Delete");
                Console.WriteLine("6. Exit");

                int choice = int.Parse(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            File.Create(filePath).Close();
                            Console.WriteLine("File created!");
                            break;

                        case 2:
                            using (StreamWriter sw = new StreamWriter(filePath))
                            {
                                Console.WriteLine("Enter text (type 'exit' to stop):");
                                string line;
                                while ((line = Console.ReadLine()) != "exit")
                                {
                                    sw.WriteLine(line);
                                }
                            }
                            break;

                        case 3:
                            using (StreamReader sr = new StreamReader(filePath))
                            {
                                Console.WriteLine(sr.ReadToEnd());
                            }
                            break;

                        case 4:
                            using (StreamWriter sw = new StreamWriter(filePath, true))
                            {
                                Console.WriteLine("Enter text to append:");
                                sw.WriteLine(Console.ReadLine());
                            }
                            break;

                        case 5:
                            File.Delete(filePath);
                            Console.WriteLine("File deleted!");
                            break;

                        case 6:
                            return;
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found!");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Access denied!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
