using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    public abstract class Player
    {
        //member variable (HAS A)
        // abstract parent classes 
        //name/computer
        //pointthreshold
        public string playerName;
        public int winCounter;
        public string chooseGesture;
        public List<string> GesturesTwo;




        //constructor defalut variables
        //public Score()
        //{
        public Player()
        {
            GesturesTwo = new List<string>() { "rock", "paper", "scissor", "lizard", "spock" };
        }

        //}



        //member method (can Do)

        public abstract string ChooseName();

        public abstract string ChooseGesture();
    }
}
    
