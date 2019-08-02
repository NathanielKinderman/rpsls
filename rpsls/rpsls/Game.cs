using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class Game
    {

        //member variable (HAS A)
        //
        Player player1;
        Player player2;
        private double getNumberOfPlayers;
        public int winningThreshold;
        string Rules;
        List<string> Gestures;


        //constructors
        public Game()
        {
            Gestures = new List<string>() { "rock", "paper", "scissor", "lizard", "spock" };
        }
        //member methods (can do)
        public void RunGame()
        {
            DisplayRules();
            int numberOfPlayers = GetNumberOfPlayer();
            SettingUpPlayers(numberOfPlayers);
            player1.ChooseName();
            player2.ChooseName();


        }
        public int GetNumberOfPlayer()
        {
            //double NumberofPlayers;
            Console.WriteLine("How many Players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }

        public void DisplayRules()
        {
            Console.WriteLine("Here are the rules:" + "\n" +
                "Rock crush Scissors," + "\n" +
               "Scissors cuts Paper" + "\n" +
               "Paper covers Rock," + "\n" +
               "Lizard eats Paper" + "\n" +
               "Spock vaporize Rock" + "\n" +
               "Rock crushes Lizard" + "\n" +
               "Scissors decapitates Lizard" + "\n" +
               "Paper disproves Spock" + "\n" +
               "Lizard poisons Spock" + "\n" +
               "Spock smashes Scissors");
            Console.ReadLine(); 
          
     
        }


        private void SettingUpPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new CPU();
            }
            else
            {
                player1 = new Human();
                player2 = new Human();
            }

        }
      





        //public Wincounter()
        //{
        //   while(player1.winCounter < winningThreshold && player2.winCounter < winningThreshold)
        //    {



        //    }

        //}
        





    }
}


