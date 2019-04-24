using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourInARow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Set_activePlayer("Red");
            myTable = new Table();
        }

        Image currentPlayer;

        Table myTable;
        Player player1 = new Player("Red", FourInARow.Properties.Resources.Red);
        Player player2 = new Player("Blue", FourInARow.Properties.Resources.Blue);


        private string Get_activePlayer()
        {
            return activePlayer.Text;
        }

        private void Set_activePlayer(string newActivePlayer)
        {
            if (newActivePlayer == "Red")
            {
                currentPlayer = FourInARow.Properties.Resources.Red;
                pictureBox43.Image = currentPlayer;
                pictureBox43.Refresh();
            }
            else if (newActivePlayer == "Blue")
            {
                currentPlayer = FourInARow.Properties.Resources.Blue;
                pictureBox43.Image = currentPlayer;
                pictureBox43.Refresh();
            }
            activePlayer.Text = newActivePlayer;
        }

        private void AnyPlayerDrop(int column)
        {
            string player = Get_activePlayer();
            if (myTable.UpdateTable(column, player) == 1)
            {
                if (player == "Red")
                {
                    UpdateImage(column, myTable.columnWeight[column] - 1);
                    // check for win
                    Set_activePlayer("Blue");
                }
                else if (player == "Blue")
                {
                    UpdateImage(column, myTable.columnWeight[column] - 1);
                    // check for win
                    Set_activePlayer("Red");
                }
            }
        }

        public void UpdateImage(int column, int row)
        {
            switch (column)
            {
                case 0:
                    switch (row)
                    {
                        case 0:
                            pictureBox36.Image = currentPlayer;
                            break;
                        case 1:
                            pictureBox29.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox22.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox15.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox8.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox1.Image = currentPlayer;
                            break;
                    }
                    break;
                case 1:
                    switch (row)
                    {
                        case 0:
                            pictureBox37.Image = currentPlayer;
                            break;
                        case 1:
                            pictureBox30.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox23.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox16.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox9.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox2.Image = currentPlayer;
                            break;
                    }
                    break;
                case 2:
                    switch (row)
                    {
                        case 0:
                            pictureBox38.Image = currentPlayer;
                            break;
                        case 1:
                            pictureBox31.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox24.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox17.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox10.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox3.Image = currentPlayer;
                            break;
                    }
                    break;
                case 3:
                    switch (row)
                    {
                        case 0:
                            pictureBox39.Image = currentPlayer;
                            break;
                        case 1:
                            pictureBox32.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox25.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox18.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox11.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox4.Image = currentPlayer;
                            break;
                    }
                    break;
                case 4:
                    switch (row)
                    {
                        case 0:
                            pictureBox40.Image = currentPlayer;
                            break;
                        case 1:
                            pictureBox33.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox26.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox19.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox12.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox5.Image = currentPlayer;
                            break;
                    }
                    break;
                case 5:
                    switch (row)
                    {
                        case 0:
                            pictureBox41.Image = currentPlayer;
                            break;
                        case 1:
                            pictureBox34.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox27.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox20.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox13.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox6.Image = currentPlayer;
                            break;
                    }
                    break;
                case 6:
                    switch (row)
                    {
                        case 0:
                            pictureBox42.Image = currentPlayer;
                            break;
                        case 1:
                            pictureBox35.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox28.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox21.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox14.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox7.Image = currentPlayer;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Error in updating column image.");
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(6);
        }

        private void ResetBoard(object sender, EventArgs e)
        {
            myTable = new Table();
            Set_activePlayer("Red");

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox14.Image = null;
            pictureBox15.Image = null;
            pictureBox16.Image = null;
            pictureBox17.Image = null;
            pictureBox18.Image = null;
            pictureBox19.Image = null;
            pictureBox20.Image = null;
            pictureBox21.Image = null;
            pictureBox22.Image = null;
            pictureBox23.Image = null;
            pictureBox24.Image = null;
            pictureBox25.Image = null;
            pictureBox26.Image = null;
            pictureBox27.Image = null;
            pictureBox28.Image = null;
            pictureBox29.Image = null;
            pictureBox30.Image = null;
            pictureBox31.Image = null;
            pictureBox32.Image = null;
            pictureBox33.Image = null;
            pictureBox34.Image = null;
            pictureBox35.Image = null;
            pictureBox36.Image = null;
            pictureBox37.Image = null;
            pictureBox38.Image = null;
            pictureBox39.Image = null;
            pictureBox40.Image = null;
            pictureBox41.Image = null;
            pictureBox42.Image = null;
        }
    }
}

