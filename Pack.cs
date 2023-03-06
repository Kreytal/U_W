﻿using System;
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
                pack = pack.OrderBy(i => random.Next()).ToList();
                int half = pack.Count / 2;
                List<Card> leftHalf = pack.GetRange(0, half);
                List<Card> rightHalf = pack.GetRange(half, half); //half/half was used as pack.count would cause an error out of boundaries.
                pack.Clear();
                double counter = half;
                //foreach (Card card in leftHalf)
                //{
                //    Console.WriteLine("left h");
                //    card.Show();
                //}
                //foreach (Card card in rightHalf)
                //{
                //    Console.WriteLine("right h");
                //    card.Show();
                //}
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

                foreach (Card card in shuffledPack)
                {
                    pack.Add(card);
                }
                shuffledPack.Clear();
                foreach (Card card in pack)
                {
                    card.Show();
                }

            }
            if (typeOfShuffle == 3)
            {
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
            for (int i = 0; i < amount; i++)
            {
                dealtCards.Add(pack[0]);
                pack.RemoveAt(0);
            }
            foreach(Card card in dealtCards)
            {
                card.Show();
            }
            return dealtCards;
        }

    }
}
