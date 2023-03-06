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
            //Create required objects to proceed testing their methods
            Pack pack = new Pack();
            Validation validation = new Validation();
            //Provides choice to the user what shuffle type he'd like to use
            Console.WriteLine("How would you like to shuffle a pack of cards? 1. Fisher Yanes; 2. Riffle Shuffle; 3. No Shuffle");
            int userInput = validation.intInputValidation(1, 3);
            bool shuffled = pack.shuffleCardPack(userInput);
            //Provides choice to the user how he would like to deal the cards
            Console.WriteLine("Now choose whether you want to: 1. Deal one card; 2. Deal cards by amount");
            int dealChoice = validation.intInputValidation(1, 2);
            if (dealChoice == 1)
            {
                Console.WriteLine("One card dealt:");
                Pack.deal();
            }
            if (dealChoice == 2)
            {
                Console.WriteLine("Please enter the amount of cards you want to deal");
                int cardsToDeal = validation.intInputValidation(1, 52);
                Pack.dealCard(cardsToDeal);
            }
            
        }
    }
}
