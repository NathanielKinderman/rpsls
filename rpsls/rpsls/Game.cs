using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    public class Game
    {

        //member variable (HAS A)
        //
        Player player1;
        Player player2;
        private double getNumberOfPlayers;
        public int winningThreshold;
        string Rules;
        List<string> Gestures;
        private object results;


        //constructors
        public Game()
        {
            Gestures = new List<string>() { "rock", "paper", "scissor", "lizard", "spock" };
            winningThreshold = 3;
        }

        //member methods (can do)
        public void RunGame()
        {
            DisplayRules();
            int numberOfPlayers = GetNumberOfPlayer();
            SettingUpPlayers(numberOfPlayers);
            player1.ChooseName();
            player2.ChooseName();

            while (player1.winCounter < winningThreshold && player2.winCounter < winningThreshold)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                DetermineRoundWinner();
            }

            DetermineGameWinner();
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
               "Spock smashes Scissors" + "\n" +
               "Press Enter when Ready");
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


        public void DetermineGameWinner()
        {

            if (player1.winCounter > player2.winCounter)
            {

                Console.WriteLine("Player 1 won this game.\n");
            }
            else
            {

                Console.WriteLine("Player 2 won this game.\n");
            }

            Console.WriteLine("Total score: " + player1.winCounter + "-" + player2.winCounter + "\n");

        }

        public void DetermineRoundWinner() {
            if (player1.chooseGesture == "rock")

            {
                if (player2.chooseGesture == "scissors")
                {
                    Console.WriteLine("Rock crushes Scissors");
                    player1.winCounter++;
                }

                else if (player2.chooseGesture == "lizard")
                {
                    Console.WriteLine("Rock crushes Lizard");
                    player1.winCounter++;
                }

                else if (player2.chooseGesture == "paper")
                {
                    Console.WriteLine("Paper covers Rock");
                    player2.winCounter++;
                }

                else if (player2.chooseGesture == "spock")
                {
                    Console.WriteLine("Spock vaporize Rock");
                    player2.winCounter++;
                }

                else if (player2.chooseGesture == "rock")
                {
                    Console.WriteLine("Draw! Please try again.");
                }
            }

            else if (player1.chooseGesture == "paper")
            {
                if (player2.chooseGesture == "rock")
                {
                    Console.WriteLine("Paper covers Rock");
                    player1.winCounter++;
                }

                else if (player2.chooseGesture == "spock")
                {
                    Console.WriteLine("Paper disproves Spock");
                    player1.winCounter++;
                }

                else if (player2.chooseGesture == "scissors")
                {
                    Console.WriteLine("Scissors cuts Paper");
                    player2.winCounter++;
                }

                else if (player2.chooseGesture == "lizard")
                {
                    Console.WriteLine("Lizard eats Paper");
                    player2.winCounter++;
                }

                else if (player2.chooseGesture == "paper")
                {
                    Console.WriteLine("Draw! Please try again.");
                }
            }
            else if (player1.chooseGesture == "scissors")
            {
                if (player2.chooseGesture == "paper")
                {
                    Console.WriteLine("Scissors cuts Paper");
                    player1.winCounter++;
                }

                else if (player2.chooseGesture == "lizard")
                {
                    Console.WriteLine("Scissors decapitates Lizard");
                    player1.winCounter++;
                }

                else if (player2.chooseGesture == "rock")
                {
                    Console.WriteLine("Rock crushes Scissors");
                    player2.winCounter++;

                }
                else if (player2.chooseGesture == "spock")
                {
                    Console.WriteLine("Spock smashes Scissors");
                    player2.winCounter++;

                }
                else if (player2.chooseGesture == "scissors")
                {
                    Console.WriteLine("Draw! Please try again.");
                }
            }
            else if (player1.chooseGesture == "lizard")
            {
                if (player2.chooseGesture == "spock")
                {
                    Console.WriteLine("Lizard poisons Spock");
                    player1.winCounter++;

                }
                else if (player2.chooseGesture == "paper")
                {
                    Console.WriteLine("Lizard eats Paper");
                    player1.winCounter++;

                }
                else if (player2.chooseGesture == "rock")
                {
                    Console.WriteLine("Rock crushes Lizard");
                    player2.winCounter++;

                }
                else if (player2.chooseGesture == "scissors")
                {
                    Console.WriteLine("Scissors decapitates Lizard");
                    player2.winCounter++;

                }
                else if (player2.chooseGesture == "lizard")
                {
                    Console.WriteLine("Draw! Please try again.");
                }
            }
            else if (player1.chooseGesture == "spock")
            {
                if (player2.chooseGesture == "scissors")
                {
                    Console.WriteLine("Spock smashes Scissors");
                    player1.winCounter++;

                }
                else if (player2.chooseGesture == "rock")
                {
                    Console.WriteLine("Spock vaporizes Rock");
                    player1.winCounter++;

                }
                else if (player2.chooseGesture == "lizard")
                {
                    Console.WriteLine("Lizard poisons Spock");
                    player2.winCounter++;

                }
                else if (player2.chooseGesture == "paper")
                {
                    Console.WriteLine("Paper disproves Spock");
                    player2.winCounter++;

                }
                else if (player2.chooseGesture == "spock")
                {
                    Console.WriteLine("Draw! Please try again.");
                }
            }

            

        }
    }
}


