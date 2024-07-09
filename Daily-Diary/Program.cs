namespace Daily_Diary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\..\mydiary.txt";
           // string fileDairy = File.ReadAllText(filePath);
          bool isRunnig= true;
            while (isRunnig)
            {
               
                Console.WriteLine("Welcome to Our DailyDiary! \nChoose Process to Start:");
                Console.WriteLine("[1] View All Diary.\n[2] Write to Diary. \n[3] Delete Entry. \n[4] Count Entries. \n[5] Quit. ");
                string userChoice = Console.ReadLine();
                switch (userChoice) {
                    case "1":
                        Console.WriteLine(DailyDiary.ReadAllDairy(filePath)); 
                        break;
                        case "2":
                        DailyDiary.AddEntry(filePath);
                        break;
                        case "3":
                        DailyDiary.DeleteEntry(filePath);
                        break;
                        case "4":
                        DailyDiary.CountDaily(filePath);
                        break;
                        case "5":
                        isRunnig = false;
                        break;
                       default:
                        Console.WriteLine("Invalid choice. Please enter\n[1] View All Diary.\n[2] Write to Diary. \n[3] Delete Entry. \n[4] Count Entries. \n[5] Quit. ");
                        break;
                }

            }
            Console.WriteLine();
        }
    }
}
