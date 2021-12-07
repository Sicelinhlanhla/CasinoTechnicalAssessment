using System;
using System.Collections.Generic;

namespace Blackjack.Models
{

    public class DeckOfCards
    {
        List<Card> currentDeck;
        int sizeOfDeck;

        public DeckOfCards()
        {
            sizeOfDeck = 52;
            currentDeck = new List<Card>(sizeOfDeck);
        }

        public List<Card> getDeck()
        {
            return currentDeck;
        }

        public void MakeDefaultDeck()
        {
            Card newCard;
            for (int i = 0; i < 52; i++)
            {
                if(i<13)
                {
                    if(i==0)
                    {
                        newCard = new Card(1, 13);
                    }
                    else
                    {
                        newCard = new Card(1, i + 1);
                    }
                }
                else if(i<26)
                {
                    if(i==13)
                    {
                        newCard = new Card(2, 13);
                    }
                    else
                    {
                        newCard = new Card(2, i - 12);
                    }
                }
                else if(i<39)
                {
                    if(i==26)
                    {
                        newCard = new Card(3, 13);
                    }
                    else
                    {
                        newCard = new Card(3, i - 25);
                    }
                }
                else
                {
                    if(i==39)
                    {
                        newCard = new Card(4, 13);
                    }
                    else
                    {
                        newCard = new Card(4, i - 39);
                    }
                }
                currentDeck.Add(newCard);
            }
        }


        public void shuffleDeck()
        {
            Random random = new Random();
            List<Card> newDeck = new List<Card>(sizeOfDeck);

            int num = 0;
            for (int i = 0; i < 52; i++)
            {
                num = random.Next(0, sizeOfDeck);
                newDeck.Add(currentDeck[num]);
                currentDeck.RemoveAt(num);
                sizeOfDeck--;
            }

            for (int i = 0; i < 52; i++)
            {
                currentDeck.Add(newDeck[i]);
            }
        }
    }
}
