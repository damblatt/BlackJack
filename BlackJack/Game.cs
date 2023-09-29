using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BlackJack
{
    class Game
    {
        public List<Player> PlayerList { get; set; } = new List<Player>();
        public Croupier Croupier { get; set; } = new Croupier();
        private DataTable bets = new DataTable();

        public Game(int playerAmount) {
            for (int i = 0; i < playerAmount; i++)
            {
                AddPlayer(i);
            }
        }

        public void Start()
        {
            PrintTitle();

            GameLoop();
        }

        private void GameLoop()
        {
            bets.Clear();
            bets.Columns.Add("Player", typeof(Player));
            bets.Columns.Add("Bet", typeof(int));

            foreach (Player player in PlayerList)
            {
                int bet = player.GetBet();
                bets.Rows.Add(player, bet);
            }
        }

        public void Stop()
        {

        }

        private void PrintTitle()
        {
            Console.Clear();
            Console.WriteLine("------------------------\n|      Black Jack      |\n------------------------");
        }

        private void AddPlayer(int id)
        {
            Player player = new Player(id);
            PlayerList.Add(player);
        }

        private void DistributeCards()
        {

        }
    }
}
