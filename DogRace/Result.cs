using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
   public class Result:Aman
    {
        public String winnerDisplay(String details,int winner,int budget) {
            String []lenData = details.Split(' ');
            if (lenData.Length < 4)
            {
                return details;
            }
            else {
                //"Aman select " + Dog + " with the " + bet + " Amount";
              //  MessageBox.Show(details);

                if (Convert.ToInt32(lenData[2]) == winner)
                {
                    return lenData[0]+" has "+(budget+Convert.ToInt32(lenData[5]))+" dollar";
                }
                else {
                //    MessageBox.Show(lenData[5]);
                    return lenData[0]+" has " + (budget-Convert.ToInt32(lenData[5])) + " dollar";
                }

               
            }
        }
    }
}
