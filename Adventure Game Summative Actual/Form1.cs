//Created by Sam Wyatt and Doyle Blacklock on November 10, 2016
//To create a text based adventure game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Adventure_Game_Summative_Actual
{
    public partial class Form1 : Form
    {
        string name;//Creates a string variable to hold the name
        int scene = 0;//Intializes the scene to 0
        Random randNum = new Random();//Creates a random number generator
        bool print = false;//Creates a boolean and sets it to false

        DateTime thisDay = DateTime.Today;//Creates a variable to hold the current day

        //Creates soundplayers to play sound
        SoundPlayer winSound = new SoundPlayer(Properties.Resources.TaDa_);
        SoundPlayer themeSong = new SoundPlayer(Properties.Resources._320553__griffon_designs__dirty_grind);
        SoundPlayer billNye = new SoundPlayer(Properties.Resources.Bill_Nye__The_Science_Guy__Original_Intro___);
        SoundPlayer endGame = new SoundPlayer(Properties.Resources._178875__rocotilos__you_lose_evil);

        public Form1()
        {
            InitializeComponent();

            nameInput.MaxLength = 6;//Sets the max length of the textbox to 6 characters

            //Gives instructions to the user
            firstChoiceLabel.Text = "Press M To continue";
            secondChoiceLabel.Text = "Press B to continue";
            thirdChoiceLabel.Text = "Press N to continue";
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            name = nameInput.Text;//Sets name to the text of the textbox

            //Makes it impossible to input no name
            if (nameInput.Text == "")
            {
                titleLabel.Text = "Welcome adventurer, what is your name?\nPlease enter your name.";
            }
            else
            {
                themeSong.PlayLooping();//Plays the theme song on repeat       

                KeyPreview = true;//Makes the form track key presses

                //Makes some labels invisible
                nameInput.Visible = false;
                firstButtonLabel.Visible = false;
                beginButton.Visible = false;

                //Sets the text to that of the first scene
                titleLabel.Text = name + " looks at his phone. It reads: " + thisDay.ToString("D") + " 12:00 AM. " + name + " looks around themself and barely makes out an abandoned lab at Central. What should " + name + " do?";
                firstChoiceLabel.Text = "Check the front door";
                secondChoiceLabel.Text = "Check the back door";
                thirdChoiceLabel.Text = "Investigate the lab";
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();//Creates a graphics object

            //Creates two random numbers
            int firstChance = randNum.Next(1, 101);
            int secondChance = randNum.Next(1, 101);

            #region R button clicks
            //Switches between scene when the R button is pressed
            if (e.KeyCode == Keys.M)
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 5)
                {
                    scene = 6;
                }
                else if (scene == 9)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    scene = 13;
                }
                else if (scene == 9)
                {
                    scene = 10;
                }
                else if (scene == 7)
                {
                    scene = 9;
                }
                else if (scene == 14)
                {
                    scene = 16;
                }
                else if (scene == 17 && firstChance <= 50)//Random encounter
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 19;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 23;
                }
                else if (scene == 23)
                {
                    scene = 25;
                }
                else if (scene == 20)
                {
                    scene = 30;
                }
                else if (scene == 30)
                {
                    scene = 31;
                }
                else if (scene == 31)
                {
                    scene = 31;
                }
                else if (scene == 32 && firstChance <= 95 && secondChance <= 60)//Random encounter
                {
                    scene = 35;
                }
                else if (scene == 32 && secondChance > 60)
                {
                    scene = 34;
                }
                else if (scene == 32 && firstChance > 95)
                {
                    scene = 33;
                }
                else if (scene == 35 && firstChance <= 95 && secondChance <= 60)//Random encounter
                {
                    scene = 36;
                }
                else if (scene == 35 && secondChance > 60)
                {
                    scene = 34;
                }
                else if (scene == 35 && firstChance > 95)
                {
                    scene = 33;
                }
                else if (scene == 36 && firstChance <= 95 && secondChance <= 60)//Random encounter
                {
                    scene = 9;
                }
                else if (scene == 36 && secondChance > 60)
                {
                    scene = 34;
                }
                else if (scene == 36 && firstChance > 95)
                {
                    scene = 33;
                }
                else if (scene == 6)//Resets form to scene 1
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 3)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 4)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 8)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 11)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 12)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 13)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 15)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 19)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 21)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 25)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 18)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 26)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 27)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 28)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 29)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 33)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 34)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
                else if (scene == 16)
                {
                    themeSong.PlayLooping();

                    formGraphics.Clear(Color.Black);
                    redButtonPicture.Visible = true;
                    yellowButtonPicture.Visible = true;
                    blueButtonPicture.Visible = true;
                    firstChoiceLabel.Visible = true;
                    secondChoiceLabel.Visible = true;
                    thirdChoiceLabel.Visible = true;

                    scene = 0;
                }
            }
            #endregion
            #region blue key presses
            else if (e.KeyCode == Keys.B)//Changes scenes if the B key is pressed
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 7)
                {
                    scene = 8;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 9)
                {
                    scene = 14;
                }
                else if (scene == 14)
                {
                    scene = 15;
                }
                else if (scene == 2)
                {
                    scene = 20;
                }
                else if (scene == 17 && firstChance <= 70)//Random encounter 
                {
                    scene = 21;
                }
                else if (scene == 17)
                {
                    scene = 22;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 23;
                }
                else if (scene == 23 && secondChance <= 70 && firstChance <= 50)//Random encounter 
                {
                    scene = 26;
                }
                else if (scene == 23 && secondChance > 70)
                {
                    scene = 27;
                }
                else if (scene == 23 && firstChance > 50)
                {
                    scene = 28;
                }
                else if (scene == 20)
                {
                    scene = 29;
                }
                else if (scene == 20)
                {
                    scene = 30;
                }
                else if (scene == 31)
                {
                    scene = 32;
                }
                else if (scene == 32 && firstChance <= 50 && secondChance <= 75)//Random encounter 
                {
                    scene = 35;
                }
                else if (scene == 32 && secondChance > 75)
                {
                    scene = 34;
                }
                else if (scene == 32 && firstChance > 50)
                {
                    scene = 33;
                }
                else if (scene == 35 && firstChance <= 50 && secondChance <= 75)//Random encounter 
                {
                    scene = 36;
                }
                else if (scene == 35 && secondChance > 75)
                {
                    scene = 34;
                }
                else if (scene == 35 && firstChance > 50)
                {
                    scene = 33;
                }
                else if (scene == 36 && firstChance <= 50 && secondChance <= 75)//Random encounter 
                {
                    scene = 9;
                }
                else if (scene == 36 && secondChance > 75)
                {
                    scene = 34;
                }
                else if (scene == 36 && firstChance > 50)
                {
                    scene = 33;
                }
                else if (scene == 30)
                {
                    scene = 32;
                }
                else if (scene == 6)//Closes program
                {
                    this.Close();
                }
                else if (scene == 3)
                {
                    this.Close();
                }
                else if (scene == 4)
                {
                    this.Close();
                }
                else if (scene == 8)
                {
                    this.Close();
                }
                else if (scene == 11)
                {
                    this.Close();
                }
                else if (scene == 12)
                {
                    this.Close();
                }
                else if (scene == 13)
                {
                    this.Close();
                }
                else if (scene == 15)
                {
                    this.Close();
                }
                else if (scene == 19)
                {
                    this.Close();
                }
                else if (scene == 21)
                {
                    this.Close();
                }
                else if (scene == 25)
                {
                    this.Close();
                }
                else if (scene == 18)
                {
                    this.Close();
                }
                else if (scene == 26)
                {
                    this.Close();
                }
                else if (scene == 27)
                {
                    this.Close();
                }
                else if (scene == 28)
                {
                    this.Close();
                }
                else if (scene == 29)
                {
                    this.Close();
                }
                else if (scene == 33)
                {
                    this.Close();
                }
                else if (scene == 34)
                {
                    this.Close();
                }
                else if (scene == 16)
                {
                    this.Close();
                }
            }
            #endregion
            #region y key presses
            else if (e.KeyCode == Keys.N)//Changes scenes if Y key is pressed
            {
                if (scene == 0)
                {
                    scene = 17;
                }
                else if (scene == 17)
                {
                    scene = 24;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }
                else if (scene == 32 && firstChance <= 30 && secondChance <= 90)//Random encounter 
                {
                    scene = 35;
                }
                else if (scene == 32 && secondChance > 90)
                {
                    scene = 34;
                }
                else if (scene == 32 && firstChance > 30)
                {
                    scene = 33;
                }
                else if (scene == 35 && firstChance <= 30 && secondChance <= 90)//Random encounter 
                {
                    scene = 36;
                }
                else if (scene == 35 && secondChance > 90)
                {
                    scene = 34;
                }
                else if (scene == 35 && firstChance > 30)
                {
                    scene = 33;
                }
                else if (scene == 36 && firstChance <= 30 && secondChance <= 90)//Random encounter 
                {
                    scene = 9;
                }
                else if (scene == 36 && secondChance > 90)
                {
                    scene = 34;
                }
                else if (scene == 36 && firstChance > 30)
                {
                    scene = 33;
                }
            }
            #endregion
            switch (scene)//Switches the scene that user is on
            {
                case 0:
                    //Sets the information presented in the scene
                    titleLabel.Text = name + " looks at his phone. It reads: " + thisDay.ToString("D") + " 12:00 AM." + name + " looks around themself and barely makes out an abandoned lab at Central. What should " + name + " do?";
                    firstChoiceLabel.Text = "Check the front door";
                    secondChoiceLabel.Text = "Check the back door";
                    thirdChoiceLabel.Text = "Investigate the lab";
                    break;
                case 1:
                    titleLabel.Text = "The door is unlocked, " + name + " heres an eerie rustle behind them. What should " + name + " do?";
                    firstChoiceLabel.Text = "Run away from the mysterious noise";
                    secondChoiceLabel.Text = "Turn around and investigate";
                    thirdChoiceLabel.Text = "";
                    break;
                case 2:
                    themeSong.Stop();//Stops playing the theme song
                    billNye.PlayLooping();//Starts playing the bill nye theme sing

                    titleLabel.Text = "The door is unlocked, " + name + " hears the Bill Nye theme song behind them. Should " + name;
                    firstChoiceLabel.Text = "Sing along";
                    secondChoiceLabel.Text = "See what is going on";
                    thirdChoiceLabel.Text = "";
                    break;
                case 3:
                    billNye.Stop();//Stops playing the bill nye theme song
                    themeSong.PlayLooping();//Starts playing the theme song

                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = name + " dies of snapping their neck from jamming to Bill Nye too much. You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;//Makes print true
                    Refresh();//Calls paint event
                    break;
                case 4:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = name + " is caught by the monster and killed. You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 5:
                    titleLabel.Text = name + " sees a figure in the darkness and shuts the door then runs down the stairs to the second floor. Should " + name + " enter the library or continue running down the stairs?.";
                    firstChoiceLabel.Text = "Continue running down the stairs";
                    secondChoiceLabel.Text = "Enter the Library";
                    thirdChoiceLabel.Text = "";
                    break;
                case 6:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = name + " is caught by the monster and killed. You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 7:
                    titleLabel.Text = name + " enters the library and barricades the door with a table. " + name + " Realizes that there are only two exits. Which exit should " + name + " take?";
                    firstChoiceLabel.Text = "Left door";
                    secondChoiceLabel.Text = "Right door";
                    thirdChoiceLabel.Text = "";
                    break;
                case 8:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = name + " is trapped inside the bibrary and can't live off of eating books. You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 9:
                    titleLabel.Text = name + " runs down the stairs to the first floor. Should " + name + " go into the cafeteria or attempt to escape through the back doors.";
                    firstChoiceLabel.Text = "Cafeteria";
                    secondChoiceLabel.Text = "Back doors";
                    thirdChoiceLabel.Text = "";
                    break;
                case 10:
                    titleLabel.Text = name + " enters the cafeteria and sees that the exits are blocked. What should " + name + " do?";
                    firstChoiceLabel.Text = "Pray for your life";
                    secondChoiceLabel.Text = "Break the window";
                    thirdChoiceLabel.Text = "Fight";
                    break;
                case 11:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = "The monster uses a chair as a weapon to knock out and kill " + name + ". You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 12:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = name + " is caught by the monster and killed. You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 13:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = "God is unable to save " + name + " from the monster, You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 14:
                    titleLabel.Text = "The back doors are locked. What should " + name + " do?";
                    firstChoiceLabel.Text = "Fight the monster";
                    secondChoiceLabel.Text = "Look for another exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 15:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = name + " is caught by the monster and killed. You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 16:
                    winSound.Play();//Plays sound if user wins

                    titleLabel.Text = name + " fights the monster and wins. You win! If you want to restart press M. If you want to exit press B. ";

                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 17:
                    titleLabel.Text = name + " finds three test tubes, which one should " + name + " investigate?";
                    firstChoiceLabel.Text = "Green test tube";
                    secondChoiceLabel.Text = "Yellow test tube";
                    thirdChoiceLabel.Text = "Colourless test tube";
                    break;
                case 18:
                    winSound.Play();//Plays sound if user wins

                    titleLabel.Text = name + " picks up and unstoppers the test tube and is overtaken by a strange desire to drink the contents " + name + " begins to feel a mysterious change. " + name + " suddenly turns into a large green monster and easily escapes the school. You win! If you want to restart press M. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 19:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = name + " starts to feel strange. " + name + " has no recollection of what happens next. You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 20:
                    titleLabel.Text = name + " sees a random student jamming out to the bill nye theme song. Should " + name;
                    firstChoiceLabel.Text = "Try to get some information";
                    secondChoiceLabel.Text = "Run away";
                    thirdChoiceLabel.Text = "";
                    break;
                case 21:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = name + " unstoppers the test tube and it emits a lethal gas. You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 22:
                    titleLabel.Text = name + " unstoppers the test tube and the test tube emits a gas which is harmless. What should " + name + " do?";
                    firstChoiceLabel.Text = "Check the front door";
                    secondChoiceLabel.Text = "Check the back door";
                    thirdChoiceLabel.Text = "";
                    break;
                case 23:
                    titleLabel.Text = name + " checks the door and the door is locked. Just to be certain " + name + " checks the other door and it is also locked. What should " + name + " do?";
                    firstChoiceLabel.Text = "Wait until morning";
                    secondChoiceLabel.Text = "Attempt to break the window and escape";
                    thirdChoiceLabel.Text = "";
                    break;
                case 24:
                    titleLabel.Text = name + " unstoppers the test tube and it turns out to be just water. What should " + name + " do?";
                    firstChoiceLabel.Text = "Check the front door";
                    secondChoiceLabel.Text = "Check the back door";
                    thirdChoiceLabel.Text = "";
                    break;
                case 25:
                    winSound.Play();//Plays sound if user wins

                    titleLabel.Text = name + " survives the night but is found in the morning and suspended on the spot. You win!...kinda. If you want to restart press M. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 26:
                    winSound.Play();//Plays sound if user wins

                    titleLabel.Text = name + " breaks the window and survives the jump. " + name + " escapes the school. You win! If you want to restart press M. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 27:
                    winSound.Play();//Plays sound if user wins

                    titleLabel.Text = name + " fails to break the window. " + name + " is forced to stay the night. " + name + " survives the night but is found in the morning and suspended on the spot. You win!...kinda. If you want to restart press M. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 28:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = name + " breaks the window but dies on the jump. You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 29:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = name + " falls down in their attempt to run and breaks their neck. You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 30:
                    titleLabel.Text = "The science complex doors close as the random guy is ripped back into the science complex by a shadowy figure. Should " + name;
                    firstChoiceLabel.Text = "Check the doors";
                    secondChoiceLabel.Text = "Run down the stairs";
                    thirdChoiceLabel.Text = "";
                    break;
                case 31:
                    titleLabel.Text = "The science complex doors are locked. What should " + name + " do?";
                    firstChoiceLabel.Text = "Check the doors";
                    secondChoiceLabel.Text = "Run down the stairs";
                    thirdChoiceLabel.Text = "";
                    break;
                case 32:
                    billNye.Stop();
                    themeSong.PlayLooping();

                    titleLabel.Text = name + " reaches the third floor stairs. How should " + name + " go down the stairs?";
                    firstChoiceLabel.Text = "Walk down one at a time";
                    secondChoiceLabel.Text = "Run down the stairs";
                    thirdChoiceLabel.Text = "Sprint down halfway and then jump to the lower level";
                    break;
                case 33:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = name + " falls down in their attempt to run and breaks their neck. You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 34:
                    redButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;

                    titleLabel.Text = name + " is caught by the monster and killed. You Lose! If you want to restart press M. If you want to exit press B.";

                    print = true;
                    Refresh();
                    break;
                case 35:
                    titleLabel.Text = name + " reaches the second floor stairs. How should " + name + " go down the stairs?";
                    firstChoiceLabel.Text = "Walk down one at a time";
                    secondChoiceLabel.Text = "Run down the stairs";
                    thirdChoiceLabel.Text = "Sprint down halfway and then jump to the lower level";
                    break;
                case 36:
                    titleLabel.Text = name + " reaches the first floor stairs. How should " + name + " go down the stairs?";
                    firstChoiceLabel.Text = "Walk down one at a time";
                    secondChoiceLabel.Text = "Run down the stairs";
                    thirdChoiceLabel.Text = "Sprint down halfway and then jump to the lower level";
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Declares variables for x values of shape
            int x1 = 520;
            int x2 = 525;
            int x3 = 650;
            int x4 = 655;
            int x5 = 525;

            if (print)
            {
                themeSong.Stop();//Stops playing theme song
                endGame.Play();//Starts playing end game sound

                //Creates brushes for strings and the tombstone
                Font bigFont = new Font("Consolas", 25, FontStyle.Bold);
                Font smallFont = new Font("Consolas", 10, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.White);
                Pen whitePen = new Pen(Color.White, 2);

                for (int x = 0; x < 21; x++)//Loops the following code 20 times 
                {
                    Point[] grave = { new Point(x1, 150), new Point(x2, 150), new Point(x2, 145), new Point(x3, 145), new Point(x3, 150), new Point(x4, 150), new Point(x4, 350), new Point(x1, 350) };//Draws a tombstone for the death of the main character

                    e.Graphics.Clear(Color.Black);//Clears screen and makes it black 

                    e.Graphics.DrawPolygon(whitePen, grave);//Draws tombstone

                    //Draws text on tombstone
                    e.Graphics.DrawString("R.I.P", bigFont, drawBrush, x2, 150);
                    e.Graphics.DrawString(name, bigFont, drawBrush, x2, 180);
                    e.Graphics.DrawString("Died on:\n" + thisDay.ToString("D"), smallFont, drawBrush, x5, 220);

                    //Subtracts 20 from each variables
                    x1 -= 20;
                    x2 -= 20;
                    x3 -= 20;
                    x4 -= 20;
                    x5 -= 20;

                    Thread.Sleep(100);//Delays for 100 milliseconds
                }
                print = false;//Makes print false
            }
        }
    }
}
