using System;
using System.Collections.Generic;

namespace CupTask
{
    class Cup
    {
        List<string> UsableDie = new List<string>(); 
        List<string> Die = new List<string>();
        int numberOfDie = 0;
        public Cup()
        {
            

        }
        public void AddingToCup(string result)
            {
                Die.Add(result);
            }

        public void Display(int result)
        { 
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(Environment.NewLine + "Here is the result from Die{0}: {1}", i, result);
            }
        }
    }
}