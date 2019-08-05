using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class Human: Player
    {
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
