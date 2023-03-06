using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Pack
    {
        public List<Card> pack = new List<Card> ();

        public Pack()
        {
            //Initialise the card pack here
            for(int value = 1; value < 14; value++)
            {
                for (int suit = 1; suit < 5; suit++)
                {
                    pack.Add(new Card(value, suit));
                }
            }
            foreach (Card card in pack)
            {
                card.Show();
            }
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            //Fisher Yates Shuffle
            Random random = new Random();
            List<Card> shuffledPack = new List<Card>();
            if (typeOfShuffle == 1)
            {
                for (int i = pack.Count - 1; i > 0; i--)
                {
                    int j = random.Next(i + 1);
                    var l = pack[i];
                    pack[i] = pack[j];
                    pack[j] = l;
                }
                foreach (Card card in pack)
                {
                    card.Show();
                }
            }
            //Riffle Shuffle
            if (typeOfShuffle == 2)
            {
                int half = pack.Count / 2;
                List<Card> leftHalf = pack.GetRange(0, half);
                List<Card> rightHalf = pack.GetRange(half, pack.Count);
                while (leftHalf.Count != 0 && rightHalf.Count != half)
                {

                }
            }
            if (typeOfShuffle == 3)
            {
                Console.WriteLine("No shuffle");

                foreach (Card card in pack)
                {
                    card.Show();
                }
                return true;
            }
            return false;
        }


        public static Card deal()
        {
            //Deals one card


        }
        //public static List<Card> dealCard(int amount)
        //{
        //    //Deals the number of cards specified by 'amount'
        //}

    }
}
