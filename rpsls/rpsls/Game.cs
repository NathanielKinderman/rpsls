using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    public class Game
    {

        
        Player player1;
        Player player2;
        
        public int winningThreshold;
        
        List<string> Gestures;
        


       
        public Game()
        {
            Gestures = new List<string>() { "rock", "paper", "scissor", "lizard", "spock" };
            winningThreshold = 2;
        }

        
        public void RunGame()
        {
            Console.WriteLine("Please press enter to see the rules and again press enter to set up the game!");
            Console.ReadLine();
            DisplayRules();
                        
            int numberOfPlayers = GetNumberOfPlayer();
            SettingUpPlayers(numberOfPlayers);
            player1.ChooseName();
            player2.ChooseName();

            while (player1.winCounter < winningThreshold && player2.winCounter < winningThreshold)
            {
                Console.WriteLine(player1.playerName + "!!");
                player1.ChooseGesture();
                Console.Clear();

                Console.WriteLine(player2.playerName + "!!");
                player2.ChooseGesture();
                Console.WriteLine(player1.playerName + " " + "chose to throw" + " " + player1.gesture);
                Console.WriteLine(player2.playerName + " " +"chose to throw" + " " + player2.gesture);
                
                DetermineRoundWinner();
                Console.WriteLine( player1.playerName +" " + "Score is:" + player1.winCounter);
                Console.WriteLine(player2.playerName + " " + "score is:" + player2.winCounter);
                
                DisplayRules();
                Console.WriteLine("Please choose next gesture!");

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
                "\n"+
                "Rock crush Scissors;" + "\n" +
               "Scissors cuts Paper;" + "\n" +
               "Paper covers Rock;" + "\n" +
               "Lizard eats Paper;" + "\n" +
               "Spock vaporize Rock;" + "\n" +
               "Rock crushes Lizard;" + "\n" +
               "Scissors decapitates Lizard;" + "\n" +
               "Paper disproves Spock;" + "\n" +
               "Lizard poisons Spock;" + "\n" +
               "Spock smashes Scissors;" + "\n" +
               "\n" +
               "The game is over when whoever won 2 out 3" + "\n"+
               "Press enter to continue" +
               "\n"+
               "\n");
            Console.ReadLine();


        }


        private void SettingUpPlayers()
        {
            Console.WriteLine("Please choose 1 or 2 players");
            int numberOfPlayers =  Int32.Parse(Console.ReadLine());
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



            if (numberOfPlayers >= 3)
            {
                Console.WriteLine("Please choose either 1 or 2 players");
                SettingUpPlayers();
                
            }
            else if (numberOfPlayers == 0)                            
            {
                Console.WriteLine("Please choose either 1 or 2 players");
                SettingUpPlayers();     
            }
            
        }


        public void DetermineGameWinner()
        {

            if (player1.winCounter > player2.winCounter)
            {

                Console.WriteLine(player1.playerName + " " + "won this game.\n");
            }
            else
            {

                Console.WriteLine(player2.playerName + " " +  "won this game.\n");
            }

            Console.WriteLine("Total score: " + player1.winCounter + "-" + player2.winCounter + "\n");

        }

        public void DetermineRoundWinner() {
            if (player1.gesture == "rock")

            {
                if (player2.gesture == "scissors")
                {
                    Console.WriteLine("Rock crushes Scissors");
                    player1.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }

                else if (player2.gesture == "lizard")
                {
                    Console.WriteLine("Rock crushes Lizard");
                    player1.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }

                else if (player2.gesture == "paper")
                {
                    Console.WriteLine("Paper covers Rock");
                    player2.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }

                else if (player2.gesture == "spock")
                {
                    Console.WriteLine("Spock vaporize Rock");
                    player2.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }

                else if (player2.gesture == "rock")
                {
                    Console.WriteLine("Draw! Please try again.");
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }
            }

            else if (player1.gesture == "paper")
            {
                if (player2.gesture == "rock")
                {
                    Console.WriteLine("Paper covers Rock");
                    player1.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }

                else if (player2.gesture == "spock")
                {
                    Console.WriteLine("Paper disproves Spock");
                    player1.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }

                else if (player2.gesture == "scissors")
                {
                    Console.WriteLine("Scissors cuts Paper");
                    player2.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }

                else if (player2.gesture == "lizard")
                {
                    Console.WriteLine("Lizard eats Paper");
                    player2.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }

                else if (player2.gesture == "paper")
                {
                    Console.WriteLine("Draw! Please try again.");
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }
            }
            else if (player1.gesture == "scissors")
            {
                if (player2.gesture == "paper")
                {
                    Console.WriteLine("Scissors cuts Paper");
                    player1.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }

                else if (player2.gesture == "lizard")
                {
                    Console.WriteLine("Scissors decapitates Lizard");
                    player1.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }

                else if (player2.gesture == "rock")
                {
                    Console.WriteLine("Rock crushes Scissors");
                    player2.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);

                }
                else if (player2.gesture == "spock")
                {
                    Console.WriteLine("Spock smashes Scissors");
                    player2.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);

                }
                else if (player2.gesture == "scissors")
                {
                    Console.WriteLine("Draw! Please try again.");
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }
            }
            else if (player1.gesture == "lizard")
            {
                if (player2.gesture == "spock")
                {
                    Console.WriteLine("Lizard poisons Spock");
                    player1.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }
                else if (player2.gesture == "paper")
                {
                    Console.WriteLine("Lizard eats Paper");
                    player1.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);

                }
                else if (player2.gesture == "rock")
                {
                    Console.WriteLine("Rock crushes Lizard");
                    player2.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }
                else if (player2.gesture == "scissors")
                {
                    Console.WriteLine("Scissors decapitates Lizard");
                    player2.winCounter++;
                    Console.WriteLine(player1.winCounter + "-" + player2.winCounter);
                }
                else if (player2.gesture == "lizard")
                {
                    Console.WriteLine("Draw! Please try again.");
                }
            }
            else if (player1.gesture == "spock")
            {
                if (player2.gesture == "scissors")
                {
                    Console.WriteLine("Spock smashes Scissors");
                    player1.winCounter++;

                }
                else if (player2.gesture == "rock")
                {
                    Console.WriteLine("Spock vaporizes Rock");
                    player1.winCounter++;

                }
                else if (player2.gesture == "lizard")
                {
                    Console.WriteLine("Lizard poisons Spock");
                    player2.winCounter++;

                }
                else if (player2.gesture == "paper")
                {
                    Console.WriteLine("Paper disproves Spock");
                    player2.winCounter++;

                }
                else if (player2.gesture == "spock")
                {
                    Console.WriteLine("Draw! Please try again.");
                }
            }
           
        }
    }
}


