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
                return true;
            }
            //Riffle Shuffle
            if (typeOfShuffle == 2)
            {
                //counter to be used to how many times the pack will be shuffled
                int counter = random.Next(5, 7);
                //chance to make use of random within the shuffling
                int chance;


                for (int i = 0; i != counter; i++)
                {
                    
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
                        //Chance will generate the random number, to determine how many cards will be placed from one hand
                        chance = random.Next(-1, 100);
                        //As riffle shuffle is rarely 100% accurate, and it can not possibly deal cards 1 by 1 precicely 
                        if (chance > 50)
                        {
                            shuffledPack.Add(leftHalf[0]);
                            leftHalf.RemoveAt(0);

                        }
                        else if (chance <= 50)
                        {
                            shuffledPack.Add(rightHalf[0]);
                            rightHalf.RemoveAt(0);
                        }
                        
                    }
                    shuffledPack.AddRange(leftHalf);
                    shuffledPack.AddRange(rightHalf);
                    
                    //Store each element of shuffledPack into pack List
                    foreach (Card card in shuffledPack)
                    {
                        pack.Add(card);
                    }
                    shuffledPack.Clear();
                }
                Console.WriteLine("Pack has been shuffled via Riffle Shuffle");
                return true;

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
            foreach (Card card in dealtCards)
            {
                card.Show();
            }
            //Removes the card from the pack list as you deal
            pack.RemoveAt(0);
            //returns the pack first index values
            return dealtCards[dealtCards.Count -1];


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
