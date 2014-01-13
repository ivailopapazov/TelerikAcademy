using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintCardNames
{
    static void Main()
    {
        string cardName = "";
        // Loop for suits
        for (int i = 0; i < 4; i++)
        {
            // Loop for ranks
            for (int j = 1; j <= 13; j++)
            {
                // Switch rank name
                switch (j)
                {
                    case 1:
                        cardName = "Ace";
                        break;
                    case 2:
                        cardName = "Two";
                        break;
                    case 3:
                        cardName = "Three";
                        break;
                    case 4:
                        cardName = "Four";
                        break;
                    case 5:
                        cardName = "Five";
                        break;
                    case 6:
                        cardName = "Six";
                        break;
                    case 7:
                        cardName = "Seven";
                        break;
                    case 8:
                        cardName = "Eight";
                        break;
                    case 9:
                        cardName = "Nine";
                        break;
                    case 10:
                        cardName = "Ten";
                        break;
                    case 11:
                        cardName = "Jack";
                        break;
                    case 12:
                        cardName = "Queen";
                        break;
                    case 13:
                        cardName = "King";
                        break;
                }
                
                // Add preposition
                cardName += " of ";

                // Switch suite name
                switch (i)
                {
                    case 0:
                        cardName += "spades";
                        break;
                    case 1:
                        cardName += "Dimonds";
                        break;
                    case 2:
                        cardName += "Hearts";
                        break;
                    case 3:
                        cardName += "Clubs";
                        break;
                }

                // Print card name
                Console.WriteLine(cardName);
            }
        }
    }
}
