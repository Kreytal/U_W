using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Create contstructor of a class that takes two parameters of get;set
        public Card(int value, int suit)
        {
            
            Value = value;
            Suit = suit;
        }

        public int Value { get; set; }
        public int Suit { get; set; }

        //Show method, that will output the Value and Suit of the cards
        public void Show()
        {
            Console.WriteLine($"{Value} - {Suit}");
        }
    }
}
