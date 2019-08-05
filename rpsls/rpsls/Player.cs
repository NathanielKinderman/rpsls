using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    public abstract class Player
    {
       
        public string playerName;
        public int winCounter;
        public string gesture;
        public List<string> Gestures;




        
        
        public Player()
        {
            Gestures = new List<string>() { "rock", "paper", "scissor", "lizard", "spock" };
        }

        



        public abstract void ChooseName();

        public abstract void ChooseGesture();
    }
}
    
