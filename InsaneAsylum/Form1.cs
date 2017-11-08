using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace InsaneAsylum
{
    public partial class Form1 : Form
    {
        //globals
        bool successDoor;
        bool successJump;
        bool restartCheck = false;
        int scene = 0; //int for changing scenes when button pressed

        // random number generator
        Random successChanceDoor = new Random();
        int chanceDoor;

        Random successChanceJump = new Random();
        int chanceJump; 

        public Form1()
        {
            InitializeComponent();


            sceneTester.Text = Convert.ToString(scene);
            sceneTester.Refresh();
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
                { scene = 1; }
                else if (scene == 3)
                { scene = 4; }
                else if (scene == 4)
                { scene = 6; }
                else if (scene == 6)
                { scene = 8; }
                else if (scene == 7)
                { scene = 10; }
                else if (scene == 8)
                { scene = 11; }
                else if (scene == 11)
                { scene = 16; } 
                else if (scene == 10)
                { scene = 12; }
                else if (scene == 16)
                { scene = 19; }
                else if (scene == 19)
                { scene = 21; }

                sceneTester.Text = Convert.ToString(scene);
            }
            else if (e.KeyCode == Keys.B)  //middle choice button press
            {
                if (scene == 11) //scene that has 3 choices
                { scene = 17; }
                
                else if (scene >= 1 && scene <= 10 || scene >= 12 && scene <= 22) 
                { scene = 0;
                    restartCheck = true;
                }

            sceneTester.Text = Convert.ToString(scene);
            }
            else if (e.KeyCode == Keys.M)  //right choice button press
            {
                if (scene == 0)
                {
                    chanceDoor = successChanceDoor.Next(1, 101); //40% chance of success

                    if (chanceDoor <= 40) //40% chance of success
                    { scene = 3;
                      successDoor = true;
                    } //success
                    else
                    { scene = 2; } //fail
                }
                else if (scene == 3)
                { scene = 5; }  
                else if (scene == 7)
                { scene = 9; }
                else if (scene == 10)
                { chanceJump = successChanceJump.Next(1, 101); //50% chance of success
                    if (chanceJump <= 50)
                    { scene = 14; } //success
                    else
                    { scene = 15; } //fail
                }
                sceneTester.Text = Convert.ToString(scene); //for scene tester
            }

            switch (scene)
            {
                case 0: 
                    if (restartCheck)
                    {
                        outputLabel1.Text = "Do you look around the room for objects, or just try to open the door?"; //output
                    }

                    break;
                case 1:
                    outputLabel1.Text = "You find a metal object and quietly pry the door open..."; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();
                    //hiding
                        
                    successDoor = false;
                    outputLabel1.Refresh();
                    Thread.Sleep(3000);//sleeping
                    scene = 3; //switching scenes
                    outputLabel1.Text = "You see stairs and an exit door. Which do you choose? "; //output
                    cLabel.Text = "Stairs";
                    mLabel.Text = "Exit Door";
                    sceneTester.Text = Convert.ToString(scene);

                    break;
                case 2: //fail scene
                    outputLabel1.Text = "The door was locked and a guard heard you trying to escape...\nYou Got Caught!"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh(); //tesing

                   
                    break;
                case 3:

                    if (successDoor == true)
                    {
                        outputLabel1.Text = "The door was unlocked.\nYou see stairs and a exit door. Which do you choose? "; //output
                        outputLabel1.Refresh(); //refreshing
                        sceneTester.Refresh();
                        cLabel.Text = "Stairs";
                        mLabel.Text = "Exit Door";
                    }
                    else if (successDoor == false)
                    {
                        outputLabel1.Refresh();
                        outputLabel1.Text = "You see stairs and an exit door. Which do you choose? "; //output
                        outputLabel1.Refresh(); //refreshing
                        sceneTester.Refresh();
                        cLabel.Text = "Stairs";
                        mLabel.Text = "Exit Door";
                    }

                    break;
                case 4:
                    outputLabel1.Text = "The stairs go down and up.\nDo you go Down or Up?"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();
                    cLabel.Text = "Go down the stairs";
                    mLabel.Text = "Go up the stairs";

                    break;
                case 5: //fail scene
                    outputLabel1.Text = "Door is locked and the alarm goes off...\nYou Got Caught!"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();

                    break;
                case 6:
                    outputLabel1.Text = "You come to a hallway and hear a women screaming.\nDo you investigate or go back upstairs?"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();
                    cLabel.Text = "Investigate the sound";
                    mLabel.Text = "Go back upstairs";

                    break;
                case 7:
                    outputLabel1.Text = "You come to a hallway. Left or Right?"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();
                    cLabel.Text = "Go left";
                    mLabel.Text = "Go right";

                    break;
                case 8:
                    outputLabel1.Text = "You see the woman tied up. Still screaming for help.\nDo you untie the woman or go back upstairs?"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();
                    cLabel.Text = "Untie the woman";
                    mLabel.Text = "Go back upstairs";

                    break;
                case 9: //fail scene
                    outputLabel1.Text = "There was a guard around the corner...\nYou Got Caught!"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();

                    break;
                case 10:
                    outputLabel1.Text = "You see a open window. Do you jump?"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();
                    cLabel.Text = "No, I don't like heights!";
                    mLabel.Text = "Yeah, I'm a ninja!";

                    break;
                case 11:
                    outputLabel1.Text = "As you untie the woman, you hear someone coming down the stairs.\nDo you hide alone, hide with the woman, or try to tackle the guard?"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();
                    cLabel.Text = "Hide alone";
                    bLabel.Text = "Finish untying and hide\nwith the woman";
                    mLabel.Text = "Try to tackle the guard";

                    break;
                case 12://fail scene
                    outputLabel1.Text = "A gaurd sees you...\nYou Got Caught!"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();

                    break;
                case 13://emtpy (oops)  
                    break;
                case 14://WIN SCENE
                    outputLabel1.Text = "You jump down and roll to break your fall.\nYou Escaped!\nYou Win!"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();
                    //play clip of my inner ninja song

                    break;
                case 15://Fail scene
                    outputLabel1.Text = "You slip off the roof and land on your neck.\nYou Died!"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();

                    break;
                case 16:
                    outputLabel1.Text = "The guard stops right infront of you facing the woman.\nDo you attack the guard or stay hidden?"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();
                    cLabel.Text = "Attack the guard";
                    mLabel.Text = "Stay hidden";

                    break;
                case 17: //fail scene
                    outputLabel1.Text = "The guard saw you trying to hide with the woman...\nYou Got Caught!"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();

                    break;
                case 18: //fail scene
                    outputLabel1.Text = "You miss the guard and hit your head on the wall...\nYou Got Caught!"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();

                    break;
                case 19:
                    outputLabel1.Text = "You knock out the guard, take his keycard, and finish untying the woman.\nDo you go back to the exit door near your room,\nor find another exit?"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();
                    cLabel.Text = "Go back to the exit door upstairs";
                    mLabel.Text = "Find another exit";

                    break;
                case 20://fail scene
                    outputLabel1.Text = "The guard turns around and sees you...\nYou Got Caught!"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();

                    break;
                case 21:
                    outputLabel1.Text = "You make it back to the exit door with the woman, and the keycard works!\nYou Escaped!\nYou Win!"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();

                    break;
                case 22: //fail scene
                    outputLabel1.Text = "A guard sees you...\nYou Got Caught!"; //output
                    outputLabel1.Refresh(); //refreshing
                    sceneTester.Refresh();

                    break;
                case 23: //extra just incase
                     
                    break;
                default:
                    break;

            }
        }
    }
}
