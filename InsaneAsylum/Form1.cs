using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsaneAsylum
{
    public partial class Form1 : Form
    {
        //globals
        int scene = 0; //int for changing scenes when button pressed

        // random number generator
        Random successChanceDoor = new Random();
        int chanceDoor;

        Random successChanceJump = new Random();
        int chanceJump; 

        public Form1()
        {
            InitializeComponent();
            //display background story

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // make loading screen

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //changing scenes depending on the button pushed
            if (e.KeyCode == Keys.C)      //left choice button press
            {
                if (scene == 0)
                {

                }

            }
            else if (e.KeyCode == Keys.B)  //middle choice button press
            {

                if (scene == 0)
                {

                }
            }
            else if (e.KeyCode == Keys.M)  //right choice button press
            {

                if (scene == 0)
                {
                    //40% chance of success
                    chanceDoor = successChanceDoor.Next(1, 101);

                    if (chanceDoor <= 40)
                    {

                    }
                    else
                    {
                        //scene = 2; //fail
                    }
                }
            }

            switch (scene)
            {
                case 0: //empty (all labels done in Form1_Load)
                    break;
                case 1:

                    break;
                case 2:
                    

                    break;
                case 3:
                     

                    break;
                case 4:


                    break;
                case 5:
                     

                    break;
                case 6:
                     

                    break;
                case 7:
                     

                    break;
                case 8:
                     

                    break;
                case 9:
                     

                    break;
                case 10:
                     

                    break;
                case 11:
                     

                    break;
                case 12:
                     

                    break;
                case 13:
                     

                    break;
                case 14:
                     

                    break;
                case 15:
                     

                    break;
                case 16:
                     

                    break;
                case 17:
                     

                    break;
                case 18:
                     

                    break;
                case 19:
                     

                    break;
                case 20:
                     

                    break;
                case 21:
                     

                    break;
                case 22:
                     

                    break;
                case 23: //extra
                     

                    break;
                case 24: //extra
                     

                    break;
                case 25: //extra
                     

                    break;
                default:
                    break;

            }
        }
    }
}
