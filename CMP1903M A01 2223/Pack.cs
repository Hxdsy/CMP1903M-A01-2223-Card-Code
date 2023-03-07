using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {

        // Creates the pack list with 52 elements
        public static List<Card> pack = new List<Card>(52);

        // Pack function that initialises the pack
        public Pack()
        {
            // Iteration to add each suit into the pack list
            for (int index2 = 1; index2 < 5; index2++)
            {
                // Iteration to add each Card within the suits to the pack list
                for (int index = 1; index < 14; index++)
                {
                    pack.Add(new Card(index, index2));
                }
            }
        }

        // shuffleCardPack function that shuffles the cards depending on user input
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            // Fisher-Yates shuffle
            if (typeOfShuffle == 1)
            {
                // Creating a random number to be used
                Random randNum = new Random();
                // Looping for the list length
                for (int index = 51; index > 1; index--)
                {
                    // Getting a random number to be used as our index from randNum
                    int randomIndex = randNum.Next(index - 1);
                    // Creating a temporary card from the indexed card in the pack
                    Card tempCard = pack[index];
                    // setting the indexed card to our random indexed card
                    pack[index] = pack[randomIndex];
                    // Replacing our random indexed card with our temporary card created earlier
                    pack[randomIndex] = tempCard;
                }
                // Shuffled - returns true
                return (true);
            }
            // Riffle shuffle
            if (typeOfShuffle == 2)
            {
                // Creating temp lists which are copies of the pack
                List<Card> tempList1 = new List<Card>(pack);
                List<Card> tempList2 = new List<Card>(pack);
                // Cutting the pack in half by halving both lists on opposite sides
                tempList1.RemoveRange(0, 26);
                tempList2.RemoveRange(26, 26);
                // Clearing pack list to allow the cards to be shuffled when added
                pack.Clear();
                //  Iteration to Add the new cards into their newly shuffled form within the pack list
                for (int index = 0; index < 26; index++)
                {
                    pack.Add(tempList1[index]);
                    pack.Add(tempList2[index]);
                }
                // Shuffled - returns true
                return (true);
            }
            // No shuffle
            else
            {
                // No shuffle - returns false
                return (false);
            }
        }

        // Deals a singular card to the player
        public static Card deal()
        {
            Card cardToReturn = pack[0];
            pack.RemoveAt(0);
            return cardToReturn;
        }

        // Deals a number of specified cards to the player
        public static List<Card> dealCard(int amount)
        {
            List<Card> cardsToReturn = new List<Card>(amount);
            for (; amount > 0; amount--)
            {
                Card cardToAdd = pack[0];
                cardsToReturn.Add(cardToAdd);
                pack.RemoveAt(0);
            }
            return cardsToReturn;
        }


        // writePack function used for testing to show that the pack is being created/shuffled correctly
        public static void writePack()
        {
            foreach(Card card in pack)
            {
                Console.WriteLine(card.Suit+" "+card.Value);
            }
            Console.ReadLine();
        }


    }   
}