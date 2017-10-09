using System;
using System.Collections.Generic;
using System.Threading;

namespace CupTask
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Die D4 = new Die(4);
            Die D6 = new Die(6);
            Die D8 = new Die(8);
            Die D10 = new Die(10);
            Die D12 = new Die(12);
            Die D20 = new Die(20);
    
            Cup cup1 = new Cup();

            List<string> UsableDie = new List<string>();
            UsableDie.Add("D4");
            UsableDie.Add("D6");
            UsableDie.Add("D8");
            UsableDie.Add("D10");
            UsableDie.Add("D12");
            UsableDie.Add("D20");
            
            string result;

            bool selectionDone = true;
            while (selectionDone == true)
            {
                
                int amountInList = UsableDie.Count;
                for(int i = 0; i < amountInList; i++)
                {
                    Console.WriteLine("{0}) " + UsableDie[i], i);
                }

                Console.Write(Environment.NewLine + "Please select which sided dice you want to use: ");
                int userSelection = Convert.ToInt16(Console.ReadLine());
                
                

                Console.WriteLine("You have selected: {0}", UsableDie[userSelection]);
                
                Console.Write("Do you wish to select another dice: Y/N");
                char userResponse = Console.ReadKey().KeyChar;

                result = UsableDie[userSelection];
                cup1.AddingToCup(result);

                if(userResponse == 'n')
                    selectionDone = false; 

            





            }





            Console.WriteLine("Shaking cup...");
            Thread.Sleep(2000);
            Console.WriteLine("Little more...");

            
        }
    }
}