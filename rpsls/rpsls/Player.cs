using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class Player
    {
        //member variable (HAS A)
        // abstract parent classes 
        //name/computer
        //pointthreshold
        public string playerName;
        public int winCounter;
        public string chooseGesture;




        //constructor defalut variables
        //public Score()
        //{
        //    int wintCounter = 0;

        //}



        //member method (can Do)

        public string ChooseName()
        {
            Console.WriteLine("Choose Your Name");
            playerName = Console.ReadLine();
            return playerName;
        }



        //public abstract void chooseGesture();
    }
}
    
