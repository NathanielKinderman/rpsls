using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class Human: Player
    {//child class of player class
     //member variables (Has A)


        //construtor 


        //member method (Can do)

        public override string ChooseName()
        {
            Console.WriteLine("Choose Your Name");
            playerName = Console.ReadLine();
            return playerName;
        }
        public override string ChooseGesture()
        {
            Console.WriteLine("Make your Choice to Throw");
            chooseGesture = Console.ReadLine();
            return chooseGesture;

        }
    }
}
