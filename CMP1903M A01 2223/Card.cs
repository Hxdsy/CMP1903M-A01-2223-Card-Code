using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        // Main code for the Card class

        // Getting and setting the variables used within the constructor
        private int cardNumber;
        public int Value
        {
            get => cardNumber;
            set
            {
                if (value > 13 || value < 1) // Validation to check that the number is within the range for the cards
                {
                    throw new ArgumentException("Number for card is not within the specified range"); // Throwing an exception to show that the card is not within the range
                }
                cardNumber = value;
            }
        }
        private int suitNumber;
        public int Suit
        {
            get => suitNumber;
            set
            {
                if (value > 4 || value < 1) // Validation to check that the number is within the range of suits
                {
                    throw new ArgumentException("Number for suit of the card is not within the specified range"); // Throwing an exception to show that the card is not within the range
                }
                suitNumber = value;
            }
        }

        // The constructor for the class
        public Card(int v, int s) 
        {
            Value = v;
            Suit = s;
        }
    }
}
