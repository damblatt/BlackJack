using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Player
    {
        public int Id;
        public int Bankroll;
        public List<Card> Cards;
        
        public Player(int id)
        {
            Id = id;
        }

        public int GetBet()
        {
            Console.WriteLine($"You have {Bankroll} Credits in your bankroll. How much would you like to bet?");
            return Int32.Parse(Console.ReadLine());
            //TODO: Check if the player has enough credits in his bankroll. If not, ask him for a new bet.
        }
    }
}
