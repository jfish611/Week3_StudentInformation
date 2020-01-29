using System;

namespace Lab3._1_StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            string[] classNames = new string[] {"Jacob","Shirah", "Noemie", "Lea", "Hudi", "Rafi", "Zach", "Dasi", "Buddy", "Andrea"};
            string[] candyFavorite = new string[] {"Lamb, fool!", "Cheese", "Hershey Kisses", "AirHeads", "Kit Kat", "M&Ms", "Breast Milk", "Breast Milk", "Halva", "Speatzel" };
            string[] previousTitle = new string[] {"Quality Analyst", "Behavior Analyst", "Adolescent", "Mouth Breather", "Youngest of Oldest", "BigBoiii", "Baby1", "Baby2", "Zaidy", "Safta" };



                for (int i = 0; i < classNames.Length; i++)
                {
                    Console.WriteLine(i+1 + "\t" + classNames[i]);
                }
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Which person would you like to find out further information on?");
                int.TryParse((Console.ReadLine()), out int choice);
                if (choice > 0 && choice <= classNames.Length)
                {
                    Console.WriteLine($"Which information would you like to know about {classNames[choice-1]}? \n1:\tFavorite Candy\n2:\tPrevious Title\n3:\tBoth");
                    string whichOption = Console.ReadLine();

                    Console.WriteLine(".........................................................");
                    if (whichOption.ToLower().Contains("favorite") || whichOption.ToLower().Contains("candy") || whichOption.ToLower().Contains("1"))
                    {
                        Console.WriteLine(choice + ":\t" + classNames[choice - 1] + "\t" + candyFavorite[choice - 1]);
                    }
                    else if (whichOption.ToLower().Contains("previous") || whichOption.ToLower().Contains("title") || whichOption.ToLower().Contains("2"))
                    {
                        Console.WriteLine(choice + ":\t" + classNames[choice - 1] + "\t" + previousTitle[choice - 1]);
                    }
                    else if (whichOption.ToLower().Contains("both") || whichOption.ToLower().Contains("3"))
                    {
                        Console.WriteLine(choice + ":\t" + classNames[choice - 1] + "\t" + candyFavorite[choice - 1] + "\t" + previousTitle[choice - 1]);
                    }
                }
                else
                {
                    Console.WriteLine("That's not a valid option.");
                }
                Console.WriteLine(".........................................................");
                Console.WriteLine("\nWould you like to select another person? Select y/n");
                string keepGoingQuestion = Console.ReadLine();
                if (keepGoingQuestion.ToLower() == "y")
                {
                    keepGoing = true;
                }
                else if (keepGoingQuestion.ToLower() == "n")
                {
                    keepGoing = false;
                    Console.WriteLine("   Byeeeeeee");
                }
            }
        }
    }

}
