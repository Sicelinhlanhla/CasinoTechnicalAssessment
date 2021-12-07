using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Blackjack.Models;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            CasinoLogic casinoLogic = new CasinoLogic();
            Console.WriteLine("Welcome to Derivco Casino");
            Console.WriteLine("_______________________________________");
            Console.Write("To play the game please enter your name:");
            string playerName = Console.ReadLine();
            Console.WriteLine("Starting Game.......");
            Thread.Sleep(2000);
            casinoLogic.Play(playerName);
        }

       
    }
}
