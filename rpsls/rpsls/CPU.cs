using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class CPU : Player
    {//child class of player class
     //member variable



        //constructor


        //member methods
        public override string ChooseName()
        {
            Console.WriteLine("Choose Computer's Name");
            playerName = Console.ReadLine();
            return playerName;
        }
        public override string ChooseGesture()
        {
            chooseGesture = GesturesTwo[1];
            return chooseGesture;
        }
    }
}
