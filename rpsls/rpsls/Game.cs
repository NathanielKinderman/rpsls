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
        }
        public int GetNumberOfPlayer()
        {
            double NumberofPlayers;
            Console.WriteLine("How many Players?");

            return int.Parse(Console.ReadLine());




        }

        public string DisplayRules()
        {
            Console.WriteLine("Here are the rules;" + "Rock beats Scissors," +
               " Scissors beats Paper" +
               " Paper beats Rock," +
               " Lizard beats Paper" +
               "Spock beats Rock" +
               "Rock beats Lizard" +
               "Scissors beats Lizard" +
               "Paper beats Spock" +
               "Lizard beats Spock" +
               "Spock beats Scissors");
            return (Console.ReadLine()); 
          
     
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

