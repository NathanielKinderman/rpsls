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


        public Game()
        {
            Gestures = new List<string>() { "rock", "paper", "scissor", "lizard", "spock" };

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
                }
                else if (player2.chooseGesture == "paper")
                {
                    Console.WriteLine("Paper covers Rock");
                }
                else if (player2.chooseGesture == "spock")
                {
                    Console.WriteLine("Spock vaporize Rock");
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
                }
                else if (player2.chooseGesture == "spock")
                {
                    Console.WriteLine("Paper disproves Spock");
                }
                else if (player2.chooseGesture == "scissors")
                {
                    Console.WriteLine("Scissors cuts Paper");
                }
                else if (player2.chooseGesture == "lizard")
                {
                    Console.WriteLine("Lizard eats Paper");
                }
                else if (player2.chooseGesture == "paper")
                {
                    Console.WriteLine("Draw! Please try again.");
                }

                else if (player1.chooseGesture == "scissors")
                {
                    if (player2.chooseGesture == "paper")
                    {
                        Console.WriteLine("Scissors cuts Paper");
                    }
                    else if (player2.chooseGesture == "lizard")
                    {
                        Console.WriteLine("Scissors decapitates Lizard");
                    }
                    else if (player2.chooseGesture == "rock")
                    {
                        Console.WriteLine("Rock crushes Scissors");
                    }
                    else if (player2.chooseGesture == "spock")
                    {
                        Console.WriteLine("Spock smashes Scissors");
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
                    }
                    else if (player2.chooseGesture == "paper")
                    {
                        Console.WriteLine("Lizard eats Paper");
                    }
                    else if (player2.chooseGesture == "rock")
                    {
                        Console.WriteLine("Rock crushes Lizard");
                    }
                    else if (player2.chooseGesture == "scissors")
                    {
                        Console.WriteLine("Scissors decapitates Lizard");
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
                    }
                    else if (player2.chooseGesture == "rock")
                    {
                        Console.WriteLine("Spock vaporizes Rock");
                    }
                    else if (player2.chooseGesture == "lizard")
                    {
                        Console.WriteLine("Lizard poisons Spock");
                    }
                    else if (player2.chooseGesture == "paper")
                    {
                        Console.WriteLine("Paper disproves Spock");
                    }
                    else if (player2.chooseGesture == "spock")
                    {
                        Console.WriteLine("Draw! Please try again.");
                    }
                }


            }



            //public void RunGame()
            //{
            //   while(player1.winCounter < winningThreshold && player2.winCounter < winningThreshold)
            //    {



            //    }

            //}






        }
    }
}


