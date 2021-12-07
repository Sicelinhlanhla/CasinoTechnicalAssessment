using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class CasinoLogic
    {
        public void Play(string playerName)
        {

            DeckOfCards deckOfCards = new DeckOfCards();
            List<Card> cards;

            deckOfCards.MakeDefaultDeck();
            int MinumumCardsToDeal = 20;
            bool winner = false;
            int DealerTotal = 0;
            int playerTotal = 0;

            deckOfCards.shuffleDeck();

            cards = deckOfCards.getDeck();

            List<Card> playerHand = new List<Card>();
            List<Card> DealerHand = new List<Card>();

            while (cards.Count() > MinumumCardsToDeal && !winner)
            {

                playerHand.Add(cards.ElementAt(0));
                playerTotal = playerTotal + cards.ElementAt(0).Value;//.getValue();
                cards.RemoveAt(0);
                Console.Write("your first card is :");
                printlist(playerHand);

                Console.WriteLine("Would you like another card? ");
                Console.Write("Please input Y for yes and N for No : ");
                string playersChoice = Console.ReadLine();
                playersChoice.ToUpper();
                Console.WriteLine("Shuffling......");
                Thread.Sleep(2000);

                while (!playersChoice.Equals("Y") && !playersChoice.Equals("N"))
                {
                    Console.WriteLine("Would you like another card? ");
                    Console.Write("Please input Y for yes and N for No : ");
                    playersChoice = Console.ReadLine();
                    playersChoice.ToUpper();
                    Console.WriteLine("Shuffling......");
                  //  Thread.Sleep(3000);
                }

                while (playersChoice.Equals("Y") && playerTotal < 22 && !winner)
                {

                    playerHand.Add(cards.ElementAt(0));
                    playerTotal = playerTotal + cards.ElementAt(0).Value;
                    cards.RemoveAt(0);
                    printlist(playerHand);

                    if (playerTotal > 21)
                    {
                        winner = true;
                        Console.WriteLine("Calculating your total......");
                        Thread.Sleep(2000);
                        Console.WriteLine(playerName + " your total is " + playerTotal + " you have lost the game. dealer wins");
                        Console.Write("Would you like to Go again? :");
                        string reply = Console.ReadLine();

                        if (reply.Equals("Y"))
                        {
                            Console.Clear();
                            Play(playerName);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Would you like another card? ");
                        Console.Write("Please input Y for yes and N for No : ");
                        playersChoice = Console.ReadLine();
                        playersChoice.ToUpper();
                        Console.WriteLine("Shuffling......");
                    }

                }
                while (playersChoice.Equals("N") && DealerTotal < 17 && !winner)
                {

                    DealerHand.Add(cards.ElementAt(0));
                    DealerTotal = DealerTotal + cards.ElementAt(0).Value;
                    cards.RemoveAt(0);
                    Console.WriteLine("getting dealer's hand.....");
                    Thread.Sleep(2000);
                    printlist(DealerHand);

                    if (DealerTotal >= 17)
                    {
                        winner = true;
                        Console.WriteLine("Calculating your total......");
                        Thread.Sleep(2000);
                        Console.WriteLine("Congratulations " + playerName + " your total is " + playerTotal + " you have won the game. dealer lost with a total of " + DealerTotal);
                        Console.Write("Would you like to Go again? :");
                        string reply = Console.ReadLine();

                        if(reply.Equals("Y"))
                        {
                            Console.Clear();
                            Play(playerName);
                        }
                    }
                    else if (DealerTotal > playerTotal && DealerTotal < 22)
                    {
                        winner = true;
                        Console.WriteLine("Calculating your total......");
                        Thread.Sleep(2000);
                        Console.WriteLine(playerName + " your total is " + playerTotal + " you have lost the game. dealer wins");
                        Console.Write("Would you like to Go again? :");
                        string reply = Console.ReadLine();

                        if (reply.Equals("Y"))
                        {
                            Console.Clear();
                            Play(playerName);
                        }
                    }
                    else if (playerTotal > 21)
                    {

                        winner = true;
                        Console.WriteLine("Calculating your total......");
                        Thread.Sleep(2000);
                        Console.WriteLine(playerName + " your total is " + playerTotal + " you have lost the game. dealer wins");
                        Console.Write("Would you like to Go again? :");
                        string reply = Console.ReadLine();

                        if (reply.Equals("Y"))
                        {
                            Console.Clear();
                            Play(playerName);
                        }
                    }
                }
              

            }
            Console.ReadKey();
        }

 

        public static void printlist(List<Card> cardList)
        {
            for (int i = 0; i < cardList.Count; i++)
            {
                cardList.ElementAt(i).printCard();
            }
        }

    }
}
