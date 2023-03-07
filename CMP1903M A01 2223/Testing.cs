using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        // Creating the mainTest function to allow testing through console
        public static void mainTest()
        {
            // Test to see if pack was created successfully
            Console.WriteLine("Pack creation test");
            Pack.writePack();
            // test to see if shuffling using the fisher yates method works
            Console.WriteLine("\nFisher-Yates Shuffle test");
            bool shuffled1 = Pack.shuffleCardPack(1);
            Pack.writePack();
            Console.WriteLine("shuffled = " + shuffled1);
            // test to see if shuffling using the riffle shuffle method works
            Console.WriteLine("\nRiffle Shuffle test");
            bool shuffled2 = Pack.shuffleCardPack(2);
            Pack.writePack();
            Console.WriteLine("shuffled = " + shuffled2);
            // Test to see if dealing a singular card works
            Console.WriteLine("Dealing card...");
            Card dealtCard = Pack.deal();
            Console.WriteLine("The card dealt was " + dealtCard.Suit + " " + dealtCard.Value);
            Console.ReadLine();
            // Test to see if dealing multiple cards work
            Console.WriteLine("Dealing cards...");
            List<Card> cardsDealt = Pack.dealCard(10); // Change the number to any positive integer below 51 to test if many work
            foreach (Card cards in cardsDealt)
            {
                Console.WriteLine("The card dealt was " + cards.Suit + " " + cards.Value);
            }
            Console.WriteLine("\nEnd Of testing");
            Console.ReadLine();
        }

    }
}
