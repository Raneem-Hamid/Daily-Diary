using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Diary
{
    public class DailyDiary
    {
        public static string ReadAllDairy(string filePath)
        {
            return File.ReadAllText(filePath);

        }


        public static void AddEntry(string filePath)
        {
            Console.WriteLine("Write The Date YYYY-MM-DD");
            string userDate = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userDate))
            {
                Console.WriteLine("Empty input, try again.");
                return;
            }

            if (DateTime.TryParse(userDate, out DateTime dateEnter))
            {
                Console.WriteLine("Write The Daily:");
                string userDaily = Console.ReadLine();

                Entry newEntry = new Entry(userDate, userDaily);
                try
                {
                    File.AppendAllText(filePath, newEntry.ToString() + Environment.NewLine);
                    Console.WriteLine(" Your daily added successfully:)");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please try again.");
            }
        }



        public static void DeleteEntry(string filePath)
        {
            Console.WriteLine("Write The Date of daily that you want to delete YYYY-MM-DD");
            string userDateToDelete = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userDateToDelete))
            {
                Console.WriteLine("Empty input, try again.");
                return;
            }

            if (DateTime.TryParse(userDateToDelete, out DateTime dateEnter)) { 
                List<string> lins = File.ReadAllLines(filePath).ToList();
                 bool deleted= false;
                    for (int i = 0; i < lins.Count; i++)
                    {
                        if (lins[i] == userDateToDelete)
                        {
                            lins.RemoveAt(i);
                                i--;
                            lins.RemoveAt(i);
                            deleted = true;
                        }
                    }
                    if (deleted) 
                    {
                       Console.WriteLine("Deleted successfuly");
                    }
                else
            {
                Console.WriteLine("IDate not found");
            }
              
            }
            
        }

        public static int CountDaily(string filePath) 
        { 
            List<string> allLines = File.ReadAllLines(filePath).ToList();
            foreach (string line in allLines) { 
                if(line == null)
                {
                    allLines.Remove(line);
                    
                }

            }

            Console.WriteLine($"the number of dialy is : {allLines.Count / 2} ");
            return allLines.Count/2;

        }
        
    }
}



