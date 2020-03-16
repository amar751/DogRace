using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
   public class Sandy
    {
        //class for the player 

        public String betSet(int Dog, int Amount, int bet)
        {
            //if the better is less then the amount 
            if (Amount > bet)
            {
                return "Sandy select " + Dog + " with the " + bet + " Amount";
            }
            else
            {
                return "invalid";
            }
        }
    }
}
