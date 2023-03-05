using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Pack
    {
        List<Card> pack = new List<Card> ();

        public Pack()
        {
            //Initialise the card pack here
            for(int value = 1; value < 14; value++)
            {
                for (int suit = 0; suit < 5; suit++)
                {
                    pack.Add(new Card(value, suit));
                }
            }
            foreach (Card card in pack)
            {
                card.Show();
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            //Fisher Yates Shuffle

        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}
