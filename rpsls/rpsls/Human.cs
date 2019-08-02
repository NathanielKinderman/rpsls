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

        public override void ChooseName()
        {
            Console.WriteLine("Choose Your Name");
            playerName = Console.ReadLine();
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("Make your Choice to Throw");
            gesture = Console.ReadLine();

        }
    }
}
