// Appllication Name:   Slot Machine
// Author's Name:       Yogeshkumar Patel
// Student ID:          200334362
// Date:                April 15, 2017
// Description:         Slot machine provide user to play with starting credit and 
//                      also can bet. There is some jackpot for use to win.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class SlotMachineForm : Form
    {
        System.Media.SoundPlayer player;

        private int playerMoney = 1000;
        private int winnings = 0;
        private int jackpot = 5000;
        private int _runningJackpot;
        private float turn = 0.0f;
        private int playerBet = 0;
        private float winNumber = 0.0f;
        private float lossNumber = 0.0f;
        private string[] spinResult;
        private string fruits = "";
        private float winRatio = 0.0f;
        private float lossRatio = 0.0f;
        private int grapes = 0;
        private int bananas = 0;
        private int oranges = 0;
        private int cherries = 0;
        private int bars = 0;
        private int bells = 0;
        private int sevens = 0;
        private int blanks = 0;

        private Random random = new Random();

        public SlotMachineForm()
        {
            InitializeComponent();
        }

        /* Utility function to show Player Stats */
        private void showPlayerStats()
        {
            winRatio = winNumber / turn;
            lossRatio = lossNumber / turn;
            string stats = "";
            stats += ("Jackpot: " + jackpot + "\n");
            stats += ("Player Money: " + playerMoney + "\n");
            stats += ("Turn: " + turn + "\n");
            stats += ("Wins: " + winNumber + "\n");
            stats += ("Losses: " + lossNumber + "\n");
            stats += ("Win Ratio: " + (winRatio * 100) + "%\n");
            stats += ("Loss Ratio: " + (lossRatio * 100) + "%\n");
            //MessageBox.Show(stats, "Player Stats");

            playerBet = 0;
            stats += (TotalCreditsLabel.Text = playerMoney + "\n");
            WinnerPaidLabel.Text = winnings.ToString();
            //_runningJackpot = jackpot + (playerBet / 10);
            //JackPotLabel.Text = _runningJackpot.ToString();
        }

        /* Utility function to reset all fruit tallies*/
        private void resetFruitTally()
        {
            grapes = 0;
            bananas = 0;
            oranges = 0;
            cherries = 0;
            bars = 0;
            bells = 0;
            sevens = 0;
            blanks = 0;
        }

        /* Utility function to reset the player stats */
        private void resetAll()
        {
            // IF conditon for 
            if (MessageBox.Show("Are You Sure?", "Are you sure you want to reset the game? your stats will be wiped out.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                playerMoney = 1000;
                winnings = 0;
                jackpot = 5000;
                turn = 0;
                playerBet = 0;
                winNumber = 0;
                lossNumber = 0;
                winRatio = 0.0f;

                WinnerPaidLabel.Text = " ";
                ReelOnePictureBox.Image = Properties.Resources.cherry;
                ReelTwoPictureBox.Image = Properties.Resources.bar;
                ReelThreePictureBox.Image = Properties.Resources.orange;

                TotalCreditsLabel.Text = playerMoney.ToString();
                BetLabel.Text = "0";

            }
           
        }

        /* Check to see if the player won the jackpot */
        private void checkJackPot()
        {
            /* compare two random values */
            var jackPotTry = this.random.Next(51) + 1;
            var jackPotWin = this.random.Next(51) + 1;
            if (jackPotTry == jackPotWin)
            {
                MessageBox.Show("You Won the $" + jackpot + " Jackpot!!", "Jackpot!!");
                playerMoney += jackpot;
                jackpot = 5000;
                JackPotLabel.Text = jackpot.ToString(); // Display jackpot value to label
            }
            
        }

        /* Utility function to show a win message and increase player money */
        private void showWinMessage()
        {
            playerMoney += winnings;
            WinnerPaidLabel.Text = winnings.ToString();
            //MessageBox.Show("You Won: $" + winnings, "Winner!");
            resetFruitTally();
            checkJackPot();
        }

        /* Utility function to show a loss message and reduce player money */
        private void showLossMessage()
        {
            playerMoney -= playerBet;
            //MessageBox.Show("You Lost!", "Loss!");
            resetFruitTally();
        }

        /* Utility function to check if a value falls within a range of bounds */
        private bool checkRange(int value, int lowerBounds, int upperBounds)
        {
            return (value >= lowerBounds && value <= upperBounds) ? true : false;

        }

        /* When this function is called it determines the betLine results.
    e.g. Bar - Orange - Banana */
        private string[] Reels()
        {
            string[] betLine = { " ", " ", " " };

            // Create a array for store change image 
            PictureBox[] reel = { ReelOnePictureBox, ReelTwoPictureBox,
                                  ReelThreePictureBox};
            int[] outCome = { 0, 0, 0 };

            for (var spin = 0; spin < 3; spin++)
            {
                outCome[spin] = this.random.Next(65) + 1;

                if (checkRange(outCome[spin], 1, 27))
                {  // 41.5% probability
                    betLine[spin] = "blank";
                    reel[spin].Image = Properties.Resources.blank;
                    blanks++;
                }
                else if (checkRange(outCome[spin], 28, 37))
                { // 15.4% probability
                    betLine[spin] = "Grapes";
                    reel[spin].Image = Properties.Resources.grapes;
                    grapes++;
                }
                else if (checkRange(outCome[spin], 38, 46))
                { // 13.8% probability
                    betLine[spin] = "Banana";
                    reel[spin].Image = Properties.Resources.banana;
                    bananas++;
                }
                else if (checkRange(outCome[spin], 47, 54))
                { // 12.3% probability
                    betLine[spin] = "Orange";
                    reel[spin].Image = Properties.Resources.orange;
                    oranges++;
                }
                else if (checkRange(outCome[spin], 55, 59))
                { //  7.7% probability
                    betLine[spin] = "Cherry";
                    reel[spin].Image = Properties.Resources.cherry;
                    cherries++;
                }
                else if (checkRange(outCome[spin], 60, 62))
                { //  4.6% probability
                    betLine[spin] = "Bar";
                    reel[spin].Image = Properties.Resources.bar;
                    bars++;
                }
                else if (checkRange(outCome[spin], 63, 64))
                { //  3.1% probability
                    betLine[spin] = "Bell";
                    reel[spin].Image = Properties.Resources.bell;
                    bells++;
                }
                else if (checkRange(outCome[spin], 65, 65))
                { //  1.5% probability
                    betLine[spin] = "Seven";
                    reel[spin].Image = Properties.Resources.seven;
                    sevens++;
                }

            }
            return betLine;
        }

        /* This function calculates the player's winnings, if any */
        private void determineWinnings()
        {
            if (blanks == 0)
            {
                if (grapes == 3)
                {
                    winnings = playerBet * 10;
                }
                else if (bananas == 3)
                {
                    winnings = playerBet * 20;
                }
                else if (oranges == 3)
                {
                    winnings = playerBet * 30;
                }
                else if (cherries == 3)
                {
                    winnings = playerBet * 40;
                }
                else if (bars == 3)
                {
                    winnings = playerBet * 50;
                }
                else if (bells == 3)
                {
                    winnings = playerBet * 75;
                }
                else if (sevens == 3)
                {
                    winnings = playerBet * 100;
                }
                else if (grapes == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (bananas == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (oranges == 2)
                {
                    winnings = playerBet * 3;
                }
                else if (cherries == 2)
                {
                    winnings = playerBet * 4;
                }
                else if (bars == 2)
                {
                    winnings = playerBet * 5;
                }
                else if (bells == 2)
                {
                    winnings = playerBet * 10;
                }
                else if (sevens == 2)
                {
                    winnings = playerBet * 20;
                }
                else if (sevens == 1)
                {
                    winnings = playerBet * 5;
                }
                else
                {
                    winnings = playerBet * 1;
                }
                winNumber++;
                showWinMessage();
            }
            else
            {
                lossNumber++;
                showLossMessage();
            }

        }

        /// <summary>
        /// Spin button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpinPictureBox_Click(object sender, EventArgs e)
        {
            playerBet = 0;
            WinnerPaidLabel.Text = winnings.ToString();
            playerBet = Convert.ToInt32(BetLabel.Text);
            JackPotLabel.Text = "";
  
            // IF condition for check user bet amount
            if (playerBet == 0)
            {
                checkCredit(10);
            }
            else
            {
                if (playerMoney == 0)
                {
                    if (MessageBox.Show("You ran out of Money! \nDo you want to play again?", "Out of Money!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        resetAll();
                        showPlayerStats();
                    }
                }
                else if (playerBet > playerMoney)
                {
                    MessageBox.Show("You don't have enough Money to place that bet.", "Insufficient Funds");
                    BetLabel.Text = "0";
                    playerBet = 0;
                }
                else if (playerBet < 0)
                {
                    MessageBox.Show("All bets must be a positive $ amount.", "Incorrect Bet");
                }
                else if (playerBet <= playerMoney)
                {
                    spinResult = Reels();
                    //fruits = spinResult[0] + " - " + spinResult[1] + " - " + spinResult[2];
                    //MessageBox.Show(fruits);
                    determineWinnings();
                    turn++;
                    TotalCreditsLabel.Text = playerMoney.ToString();
                    BetLabel.Text = "0";
                    showPlayerStats();
                }
                else
                {
                    MessageBox.Show("Please enter a valid bet amount");
                }
            }
            
        }

        /// <summary>
        /// Function for check bet and allow user to lay 
        /// </summary>
        /// <param name="bet"></param>
        private void checkCredit(int bet)
        {
            if (playerMoney == 0)
            {
                if (MessageBox.Show("You ran out of Money! \nDo you want to play again?", "Out of Money!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resetAll();
                    showPlayerStats();
                }
            }
            else if (playerBet > playerMoney)
            {
                MessageBox.Show("You don't have enough Money to place that bet.", "Insufficient Funds");
            }
            else if (playerBet < 0)
            {
                MessageBox.Show("All bets must be a positive $ amount.", "Incorrect Bet");
            }
            else if (playerBet <= playerMoney)
            {
                playerBet += bet;
                TotalCreditsLabel.Text = playerMoney.ToString();
                BetLabel.Text = playerBet.ToString();
            }
        }

        /// <summary>
        /// Load form event handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SlotMachineForm_Load(object sender, EventArgs e)
        {
            // Set default value when form load 
            TotalCreditsLabel.Text = playerMoney.ToString();
            BetLabel.Text = "0";
            WinnerPaidLabel.Text = "0";
            ReelOnePictureBox.Image = Properties.Resources.cherry;
            ReelTwoPictureBox.Image = Properties.Resources.bar;
            ReelThreePictureBox.Image = Properties.Resources.orange;

            playSimpleSound(); // Call function 

        }

        /// <summary>
        /// Reset button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetPictureBox_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        /// <summary>
        /// Power button clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PowerPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo);
            
            // IF result is yes user may exit from application
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for playing!", "Thank You");
                Application.Exit();
            }
            else
            {
                // User will stay on app
            }
        }

        /// <summary>
        /// Bet button clicked event handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BetFiftyPictureBox_Click(object sender, EventArgs e)
        {
            checkCredit(50);
        }

        /// <summary>
        /// Bet button clicked event handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BetHundredPictureBox_Click(object sender, EventArgs e)
        {
            checkCredit(100);
        }

        /// <summary>
        /// Bet button clicked event handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BetFiveHundredPictureBox_Click(object sender, EventArgs e)
        {
            checkCredit(500);
        }
        /// <summary>
        /// Function for play wav audio file 
        /// </summary>
        private void playSimpleSound()
        {
            // make a new player object add set with value 
            player = new System.Media.SoundPlayer(SlotMachine.Properties.Resources.Slot_Machine_Sound_Effects_converted);
            player.Load(); // Load that sound file
            player.PlayLooping(); // Play wave file in loop
        }
        /// <summary>
        /// Form close event handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SlotMachineForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
