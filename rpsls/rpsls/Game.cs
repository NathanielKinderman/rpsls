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
            getNumberOfPlayers = GetNumberOfPlayer();
            DisplayRules();

        }
        public int GetNumberOfPlayer()
        {
            //double NumberofPlayers;
            Console.WriteLine("How many Players?");

            return int.Parse(Console.ReadLine());




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


        //private void settingUpPlayers(int NumberOfPlayers)
        //{
        //    if (int NumberOfPlayers() == 1)
        //        Player1 = new Human();
        //    Player2 = new CPU();

        //    else (Player1 = new Human();
        //    Player2 = new Human();


            //}
            //public void RunGame();
            //    int number = GetNumberOfPlayers();
            //    SettingUpPlayer(numberPlayers)
            //    player1 this.ChooseName();
            //    //player1 ChooseGesture();
            //   // player2 ChooseGesture();

            //    }






        }
    }
//}

