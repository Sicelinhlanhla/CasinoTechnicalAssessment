using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Models
{
   public class CasinoEnums
    {
        public enum Suits
        {
            Hearts=1,
            Spades = 2,
            Clubs = 3,
            Diamonds = 4,
        }
        public enum CardValue
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine= 9,
            Ten=10,
            Jack = 11,
            Queen = 12,
            King = 13
        }
    }
}
