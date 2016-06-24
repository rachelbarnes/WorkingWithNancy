using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = Card.getRandomCard();
            Console.Write(card.Rank +", " );
            Console.WriteLine(card.Suit);

            var playerList = new List<Player>() { new Player() };
            Game.start(playerList);
        }
    }
}
