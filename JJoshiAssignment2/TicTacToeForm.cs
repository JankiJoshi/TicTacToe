
/* 
 * TicTacToeForm.cs
 * Assignment 2
 * Revision History,
 *      Janki Joshi, 2016.10.03: designed
 *      Janki Joshi, 2016.10.04: design [modified]
 *      Janki Joshi, 2016.10.06: created
 *      Janki Joshi, 2016.10.08: created[continued]
 *      Janki Joshi, 2016.10.09: design [modified], added comments, debugged                               
 *                               
 */

using System;
using System.Windows.Forms;


namespace JJoshiAssignment2
{
    /// <summary>
    /// Tic Tac Toe form to set the images to pictureboxes and calculate and show the winner
    /// </summary>
    public partial class TicTacToeForm : Form
    {
        // to change the player and images from x to o and 
        bool flag = true;

        // storing the images into a bitmap
        System.Drawing.Bitmap b = (Properties.Resources.x);
        System.Drawing.Bitmap c = (Properties.Resources.o);

        // keeps track of the winner
        string winner;

        // constant variable that has th totl number of pictureBoxes used in the form
        const int totalPictureBoxes = 9;

        // array of pictureBox
        PictureBox[] pictureBoxArray;

        /// <summary>
        /// constructor that initializes the components of the form
        /// </summary>
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A pictureBox Click event that declares the winner and restart the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pB_Click(object sender, System.EventArgs e)
        {
            pictureBoxArray = new PictureBox[totalPictureBoxes] { pB1, pB2, pB3, pB4, pB5, pB6, pB7, pB8, pB9 };
            b.Tag = "helloX";
            c.Tag = "helloY";

            try
            {
                // Calling a method that initializes the image and calculates the winner
                gameStart(sender);

                if (winner == "X")
                {
                    MessageBox.Show(" X Wins! ", "RESULT", MessageBoxButtons.OK);
                    for (int k = 0; k < totalPictureBoxes; k++)
                    {
                        if (pictureBoxArray[k] != null)
                        {
                            pictureBoxArray[k].Image = null;
                            pictureBoxArray[k].Enabled = true;
                            flag = true;
                        }
                    }
                    winner = "";
                    return;
                }

                if (winner == "O")
                {
                    MessageBox.Show(" O Wins! ", "RESULT", MessageBoxButtons.OK);
                    for (int k = 0; k < totalPictureBoxes; k++)
                    {
                        if (pictureBoxArray[k] != null)
                        {
                            pictureBoxArray[k].Image = null;
                            pictureBoxArray[k].Enabled = true;
                            flag = true;
                        }
                    }
                    winner = "";
                    return;
                }

                int a = 0;
                for (int j = 0; j < totalPictureBoxes; j++)
                {
                    if (pictureBoxArray[j].Image != null)
                    {
                        a++;
                    }
                }
                if (a == 9)
                {
                    MessageBox.Show(" Stalemate! ", "RESULT", MessageBoxButtons.OK);
                    for (int k = 0; k < totalPictureBoxes; k++)
                    {
                        if (pictureBoxArray[k] != null)
                        {
                            pictureBoxArray[k].Image = null;
                            pictureBoxArray[k].Enabled = true;
                            flag = true;
                        }
                    }
                    winner = "";
                    return;
                }
            }

            catch (Exception e1)
            {
                e1.Message.ToString();
            }
        }


        /// <summary>
        /// methos that calculates the winner
        /// </summary>
        /// <param name="sender">this is an picturebox object send</param>

        public void gameStart(object sender)
        {

            if (sender is PictureBox)
            {
                PictureBox pictureBoxReference = (PictureBox)sender;

                for (int i = 0; i < totalPictureBoxes; i++)
                {
                    if (pictureBoxReference == pictureBoxArray[i])
                    {
                        if (flag == true)
                        {
                            pictureBoxArray[i].Image = b;
                            pictureBoxArray[i].Image.Tag = b.Tag;
                            flag = false;
                            pictureBoxArray[i].Enabled = false;
                            break;
                        }
                        else
                        {
                            pictureBoxArray[i].Image = c;
                            pictureBoxArray[i].Image.Tag = c.Tag;
                            flag = true;
                            pictureBoxArray[i].Enabled = false;
                            break;
                        }
                    }
                }

                if (pictureBoxArray[0].Image != null && pictureBoxArray[1].Image != null && pictureBoxArray[2].Image != null)
                {
                    if (pictureBoxArray[0].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[1].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[2].Image.Tag.ToString() == b.Tag.ToString())
                    {
                        winner = "X";
                    }
                    if (pictureBoxArray[0].Image.Tag.ToString() == c.Tag.ToString()
                        && (pictureBoxArray[1].Image.Tag.ToString()) == c.Tag.ToString()
                        && (pictureBoxArray[2].Image.Tag.ToString() == c.Tag.ToString()))
                    {
                        winner = "O";
                    }
                }

                if (pictureBoxArray[3].Image != null && pictureBoxArray[4].Image != null && pictureBoxArray[5].Image != null)
                {
                    if (pictureBoxArray[3].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[4].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[5].Image.Tag.ToString() == b.Tag.ToString())
                    {
                        winner = "X";
                    }
                    if (pictureBoxArray[3].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[4].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[5].Image.Tag.ToString() == c.Tag.ToString())
                    {
                        winner = "O";
                    }
                }

                if (pictureBoxArray[6].Image != null && pictureBoxArray[7].Image != null && pictureBoxArray[8].Image != null)
                {
                    if (pictureBoxArray[6].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[7].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[8].Image.Tag.ToString() == b.Tag.ToString())
                    {
                        winner = "X";
                    }
                    if (pictureBoxArray[6].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[7].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[8].Image.Tag.ToString() == c.Tag.ToString())
                    {
                        winner = "O";
                    }
                }

                if (pictureBoxArray[0].Image != null && pictureBoxArray[3].Image != null && pictureBoxArray[6].Image != null)
                {
                    if (pictureBoxArray[0].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[3].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[6].Image.Tag.ToString() == b.Tag.ToString())
                    {
                        winner = "X";
                    }
                    if (pictureBoxArray[0].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[3].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[6].Image.Tag.ToString() == c.Tag.ToString())
                    {
                        winner = "O";
                    }
                }

                if (pictureBoxArray[1].Image != null && pictureBoxArray[4].Image != null && pictureBoxArray[7].Image != null)
                {
                    if (pictureBoxArray[1].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[4].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[7].Image.Tag.ToString() == b.Tag.ToString())
                    {
                        winner = "X";
                    }
                    if (pictureBoxArray[1].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[4].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[7].Image.Tag.ToString() == c.Tag.ToString())
                    {
                        winner = "O";
                    }
                }
                if (pictureBoxArray[2].Image != null && pictureBoxArray[5].Image != null && pictureBoxArray[8].Image != null)
                {
                    if (pictureBoxArray[2].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[5].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[8].Image.Tag.ToString() == b.Tag.ToString())
                    {
                        winner = "X";
                    }
                    if (pictureBoxArray[2].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[5].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[8].Image.Tag.ToString() == c.Tag.ToString())
                    {
                        winner = "O";
                    }
                }


                if (pictureBoxArray[2].Image != null && pictureBoxArray[4].Image != null && pictureBoxArray[6].Image != null)
                {
                    if (pictureBoxArray[2].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[4].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[6].Image.Tag.ToString() == b.Tag.ToString())
                    {
                        winner = "X";
                    }
                    if (pictureBoxArray[2].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[4].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[6].Image.Tag.ToString() == c.Tag.ToString())
                    {
                        winner = "O";
                    }
                }
                if (pictureBoxArray[0].Image != null && pictureBoxArray[4].Image != null && pictureBoxArray[8].Image != null)
                {
                    if (pictureBoxArray[0].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[4].Image.Tag.ToString() == b.Tag.ToString()
                        && pictureBoxArray[8].Image.Tag.ToString() == b.Tag.ToString())
                    {
                        winner = "X";
                    }

                    if (pictureBoxArray[0].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[4].Image.Tag.ToString() == c.Tag.ToString()
                        && pictureBoxArray[8].Image.Tag.ToString() == c.Tag.ToString())
                    {
                        winner = "O";
                    }
                }
            }
            else
            {
                MessageBox.Show("This is not a pictureBox");
            }
        }
    }
}
