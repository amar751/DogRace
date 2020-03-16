using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    public partial class Form1 : Form
    {

        int Dog = 0;

        int Aman = 90, Addy = 90, Sandy = 90;

        Ground objGround = new Ground();
        public Form1()
        {
            InitializeComponent();
        }

        private void Dog1_CheckedChanged(object sender, EventArgs e)
        {
            // if we want choose dog one for the bet then we use this code 
            if (Dog1.Checked==true) {
                //pass the value to the global variable 
                Dog = 1;
            }
        }

        private void Dog2_CheckedChanged(object sender, EventArgs e)
        {
            // if we want choose dog 2nd for the bet then we use this code 
            if (Dog2.Checked == true)
            {
                //pass the value to the global variable 
                Dog = 2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //object of the random class to move the dog 
            Random rd = new Random();
            p1.Left += rd.Next(1, 30);
            p2.Left += rd.Next(1, 30);
            p3.Left += rd.Next(1, 30);
            p4.Left += rd.Next(1, 30);

            //fnd the winner using the condtional statement 
            if (Convert.ToInt32(p1.Left.ToString()) >= objGround.lastPoint())
            {
                winner(1);
            }
            
            if (Convert.ToInt32(p2.Left.ToString()) >= objGround.lastPoint())
            {    
                winner(2);
            }

            if (Convert.ToInt32(p3.Left.ToString()) >= objGround.lastPoint())
            {
                winner(3);
            }
            if (Convert.ToInt32(p4.Left.ToString()) >= objGround.lastPoint())
            {
               winner(4);
            }
            
        }
        //this method is used to print the details of the winner 
        public void winner(int dogWinner)
        {

            timer1.Enabled = false;
            timer1.Stop();

            Result obj = new Result();
            if (Player1.Text.ToString().Split(' ').Length > 6)
            {
                Player1.Text = obj.winnerDisplay(Player1.Text, dogWinner, Aman);
                String[] lenData = Player1.Text.Split(' ');
                Aman=Convert.ToInt32(lenData[2]);
            }

            if (Player2.Text.ToString().Split(' ').Length > 6)
            {
                Player2.Text = obj.winnerDisplay(Player2.Text, dogWinner, Addy);
                String[] lenData2 = Player2.Text.Split(' ');
                Addy = Convert.ToInt32(lenData2[2]);
                
            }
            if (Player3.Text.ToString().Split(' ').Length > 6)
            {
                Player3.Text = obj.winnerDisplay(Player3.Text, dogWinner, Sandy);
                String[] lenData3 = Player3.Text.Split(' ');
                Sandy = Convert.ToInt32(lenData3[2]);
             //   MessageBox.Show(lenData3.Length.ToString());
            }
                MessageBox.Show(" Dog "+dogWinner.ToString() +" won the Race ");

            p1.Left = 0;
            p2.Left = 0;
            p3.Left = 0;
            p4.Left = 0;
            button2.Enabled =false;
        }

        private void Dog4_CheckedChanged(object sender, EventArgs e)
        {
            // if we want choose dog 3rd for the bet then we use this code 
            if (Dog4.Checked == true)
            {
                //pass the value to the global variable 
                Dog = 4;
            }
        }

        private void Dog3_CheckedChanged(object sender, EventArgs e)
        {
            // if we want choose dog 3rd for the bet then we use this code 
            if (Dog3.Checked == true)
            {
                //pass the value to the global variable 
                Dog = 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //after filling the all details click on the better button 
            if (Dog > 0 && PlayerNo.Value > 0 && Amount.Value > 0)
            {
                if (PlayerNo.Value == 1) {
                    //object of the player class
                    Aman obj = new Aman();
                    //calling the method of the class
                    String result = obj.betSet(Dog, Aman, Convert.ToInt32(Amount.Value));
                    if (result.Equals("invalid"))
                    {
                        MessageBox.Show("Bet Amount must be less than the Budget ");
                    }
                    else {
                        //after setting the bet 
                        Player1.Text = result;
                        button2.Enabled = true;
                    }
                } else if (PlayerNo.Value==2) {
                    //object of the player class
                    Addy obj = new Addy();
                    //calling the method of the class
                    String result = obj.betSet(Dog, Addy, Convert.ToInt32(Amount.Value));
                    if (result.Equals("invalid"))
                    {
                        MessageBox.Show("Bet Amount must be less than the Budget ");
                    }
                    else
                    {
                        //after setting the bet 
                        Player2.Text = result;
                        button2.Enabled = true;
                    }



                } else if (PlayerNo.Value==3) {
                    //object of the player class
                    Sandy obj = new Sandy();
                    //calling the method of the class
                    String result = obj.betSet(Dog, Sandy, Convert.ToInt32(Amount.Value));
                    if (result.Equals("invalid"))
                    {
                        MessageBox.Show("Bet Amount must be less than the Budget ");
                    }
                    else
                    {
                        //after setting the bet 
                        Player3.Text = result;
                        button2.Enabled = true;
                    }


                }

                //reset the variable and object of the game 
                PlayerNo.Value = 0;
                Amount.Value = 0;
                Dog1.Checked = false;
                Dog2.Checked = false;
                Dog3.Checked = false;
                Dog = 0;

            }
            else {
                //if we missed any details to fill then the error message will display
                MessageBox.Show("Select the Dog and Choose the Player and then set the Amount for the bet ");
            }
        }
    }
}
