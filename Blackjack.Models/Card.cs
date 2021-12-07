using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suits = Blackjack.Models.CasinoEnums.Suits;
using CardValues = Blackjack.Models.CasinoEnums.CardValue;

namespace Blackjack.Models
{
    public class Card
    {
        private int suit = 0;
        private int val = 0;
        private string faceCard;
        private string suitString;

        public Card()
        {
            suit = 0;
            val = 0;
            faceCard = string.Empty;
        }
        public Card(int s, int v)
        {
            Suit = s;
            val = v;
           

            switch(this.val)
            {
                case (int)CardValues.Ace:
                    faceCard = "Ace";
                    val = 1;
                    break;
                case (int)CardValues.Two:
                    faceCard = "Two";
                    val = 2;
                    break;
                case (int)CardValues.Three:
                    faceCard = "Three";
                    val = 3;
                    break;
                case (int)CardValues.Four:
                    faceCard = "Four";
                    val = 4;
                    break;
                case (int)CardValues.Five:
                    faceCard = "Five";
                    val = 5;
                    break;
                case (int)CardValues.Six:
                    faceCard = "Six";
                    val = 6;
                    break;
                case (int)CardValues.Seven:
                    faceCard = "Seven";
                    val = 7;
                    break;
                case (int)CardValues.Eight:
                    faceCard = "Eight";
                    val = 8;
                    break;
                case (int)CardValues.Nine:
                    faceCard = "Nine";
                    val = 9;
                    break;
                case (int)CardValues.Ten:
                    faceCard = "Ten";
                    val = 10;
                    break;
                case (int)CardValues.Jack:
                    faceCard = "Jack";
                    val = 10;
                    break;
                case (int)CardValues.Queen:
                    faceCard = "Queen";
                    val = 10;
                    break;
                case (int)CardValues.King:
                    faceCard = "King";
                    val = 10;
                    break;
            }

        }

        public int Suit { get { return suit; }set { suit = value; } }
        public int Value { get { return val; } set { val = value; } }
        public string getSuitString()
        {
            switch (this.suit)
            {
                case (int)Suits.Hearts:
                    suitString = "Hearts";
                    break;
                case (int)Suits.Spades:
                    suitString = "Spades";
                    break;
                case (int)Suits.Diamonds:
                    suitString = "Diamonds";
                    break;
                case (int)Suits.Clubs:
                    suitString = "Clubs";
                    break;
            }

            return suitString;
        }

        public void printCard()
        {
            getSuitString();
            Console.WriteLine(faceCard + " of " + suitString);
        }

    }
}
