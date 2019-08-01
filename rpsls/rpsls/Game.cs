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


        //constructors

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
                "Rock beats Scissors," + "\n" +
               "Scissors beats Paper" + "\n" +
               "Paper beats Rock," + "\n" +
               "Lizard beats Paper" + "\n" +
               "Spock beats Rock" + "\n" +
               "Rock beats Lizard" + "\n" +
               "Scissors beats Lizard" + "\n" +
               "Paper beats Spock" + "\n" +
               "Lizard beats Spock" + "\n" +
               "Spock beats Scissors");
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
        





    }
}


