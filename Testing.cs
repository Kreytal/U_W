using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing
    {
        public Testing()
        {
            Pack pack = new Pack();
            Validation validation = new Validation();
            Console.WriteLine("How would you like to shuffle a pack of cards? 1. Fisher Yanes; 2. Riffle Shuffle; 3. No Shuffle");
            int userInput = validation.intInputValidation(1, 3);
            bool shuffled = pack.shuffleCardPack(userInput);
            Console.WriteLine("Now choose whether you want to: 1. Deal one card; 2. Deal cards by amount");
            int dealChoice = validation.intInputValidation(1, 2);
            if (dealChoice == 1)
            {

            }
            if (dealChoice == 2)
            {

            }
            
        }
    }
}
