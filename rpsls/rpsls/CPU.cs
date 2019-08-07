using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class CPU : Player
    { 
        public override void ChooseName()
        {
            Console.WriteLine("Choose Computer's Name");
            playerName = Console.ReadLine();
        }
        public override  void  ChooseGesture()
        {
            Random rnd = new Random();
            int gestureIndex = rnd.Next(4);

            gesture = Gestures[gestureIndex];
        }
    }
}
