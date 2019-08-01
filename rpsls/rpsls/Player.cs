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




        //member method (can Do)
        public abstract void chooseName();
        public abstract void chooseGesture();
}
