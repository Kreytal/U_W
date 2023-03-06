using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Pack
    {
        static public List<Card> pack = new List<Card> ();

        public Pack()
        {
            //Initialise the card pack here
            //Loop through each card value from 1 - 13
            for(int value = 1; value < 14; value++)
            {
                //Loop through each card suit from 1 - 4
                for (int suit = 1; suit < 5; suit++)
                {
                    //Store the value/suit into the list
                    pack.Add(new Card(value, suit));
                }
            }
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            
            Random random = new Random();
            //Created a list to store shuffle pack
            List<Card> shuffledPack = new List<Card>();
            //Fisher Yates Shuffle
            if (typeOfShuffle == 1)
            {
                for (int i = 0; i < pack.Count; i++)
                {
                    int j = random.Next(i + 1);
                    var l = pack[i];
                    pack[i] = pack[j];
                    pack[j] = l;
                }
                Console.WriteLine("Pack has been shuffled via Fisher Yanes Shuffle");
                foreach (Card card in pack)
                {
                    card.Show();
                }
            }
            //Riffle Shuffle
            if (typeOfShuffle == 2)
            {
                //Randomly order pack of cards
                pack = pack.OrderBy(i => random.Next()).ToList();
                int half = pack.Count / 2;
                //split the pack of cards in 2 lists
                List<Card> leftHalf = pack.GetRange(0, half);
                List<Card> rightHalf = pack.GetRange(half, half);
                //Clear the pack to store shuffled cards later on
                pack.Clear();
                
                //While count of both left/right halfs doesn't reach 0,
                //keep dropping cards one on another proceeding riffle shuffle by storing it into shuffledPack list
                while (leftHalf.Count > 0 && rightHalf.Count > 0)
                {
                    
                    for (int i = 0; i < half; i++)
                    {
                        shuffledPack.Add(leftHalf[0]);
                        leftHalf.RemoveAt(0);
                        shuffledPack.Add(rightHalf[0]);
                        rightHalf.RemoveAt(0);
                    }
                }
                Console.WriteLine("Pack has been shuffled via Riffle Shuffle");
                //Store each element of shuffledPack into pack List
                foreach (Card card in shuffledPack)
                {
                    pack.Add(card);
                }
                //Clear the shuffledPack list
                shuffledPack.Clear();

            }
            //No shuffle choice
            if (typeOfShuffle == 3)
            {
                //doesn not proceed any shuffle
                Console.WriteLine("No shuffle proceeded");
                return true;
            }
            return false;
        }
        //List to be used for storing dealt cards
        static List<Card> dealtCards = new List<Card>();
        public static Card deal()
        {
            //Deals one card into dealtCards list
            dealtCards.Add(pack[0]);
            dealtCards[0].Show();
            //Removes the card from the pack list as you deal
            pack.RemoveAt(0);
            //returns the pack first index values
            return dealtCards[0];


        }
        public static List<Card> dealCard(int amount)
        {
            
            //Deals the number of cards specified by 'amount'
            //For loop through the shuffled deck of cards by specified by user amount
            for (int i = 0; i < amount; i++)
            {
                //Adds the top card to the dealt cards list
                dealtCards.Add(pack[0]);
                pack.RemoveAt(0);
            }
            foreach(Card card in dealtCards)
            {
                //Output method displays the content of the dealtCards list.
                card.Show();
            }
            return dealtCards;
        }

    }
}
