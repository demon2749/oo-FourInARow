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
        Table myTable;
        Player Red = new Player("Red", FourInARow.Properties.Resources.Red, true);
        Player Blue = new Player("Blue", FourInARow.Properties.Resources.Blue, false);

        public Form1()
        {
            InitializeComponent();
            myTable = new Table(Red, Blue);
            myTable.Set_activePlayer(Red);
            UpdateActivePlayer(myTable.Get_activePlayer());
        }

        private void AnyPlayerDrop(int column)
        {
            Player player = myTable.Get_activePlayer();
            Piece newPiece = new Piece(player, column, myTable.columnWeight[column]+1);

            if (newPiece.Place(myTable) == 1) // is 1 if the piece was successfully created.
            {
                UpdateImage(newPiece);
                myTable.CheckForWin(newPiece);

                if (player.Name == "Red")
                {
                    myTable.Set_activePlayer(Blue);
                    UpdateActivePlayer(myTable.Get_activePlayer());
                }
                else if (player.Name == "Blue")
                {
                    myTable.Set_activePlayer(Red);
                    UpdateActivePlayer(myTable.Get_activePlayer());
                }
            }
        }

        public void UpdateActivePlayer(Player newActivePlayer)
        {
            pictureBox43.Image = newActivePlayer.Picture;
            activePlayer.Text = newActivePlayer.Name;
        }

        public void UpdateImage(Piece Piece)
        {
            Image currentPlayer = Piece.Player.Picture;
            switch (Piece.Column)
            {
                case 1:
                    switch (Piece.Row)
                    {
                        case 1:
                            pictureBox36.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox29.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox22.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox15.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox8.Image = currentPlayer;
                            break;
                        case 6:
                            pictureBox1.Image = currentPlayer;
                            break;
                    }
                    break;
                case 2:
                    switch (Piece.Row)
                    {
                        case 1:
                            pictureBox37.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox30.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox23.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox16.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox9.Image = currentPlayer;
                            break;
                        case 6:
                            pictureBox2.Image = currentPlayer;
                            break;
                    }
                    break;
                case 3:
                    switch (Piece.Row)
                    {
                        case 1:
                            pictureBox38.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox31.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox24.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox17.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox10.Image = currentPlayer;
                            break;
                        case 6:
                            pictureBox3.Image = currentPlayer;
                            break;
                    }
                    break;
                case 4:
                    switch (Piece.Row)
                    {
                        case 1:
                            pictureBox39.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox32.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox25.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox18.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox11.Image = currentPlayer;
                            break;
                        case 6:
                            pictureBox4.Image = currentPlayer;
                            break;
                    }
                    break;
                case 5:
                    switch (Piece.Row)
                    {
                        case 1:
                            pictureBox40.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox33.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox26.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox19.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox12.Image = currentPlayer;
                            break;
                        case 6:
                            pictureBox5.Image = currentPlayer;
                            break;
                    }
                    break;
                case 6:
                    switch (Piece.Row)
                    {
                        case 1:
                            pictureBox41.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox34.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox27.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox20.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox13.Image = currentPlayer;
                            break;
                        case 6:
                            pictureBox6.Image = currentPlayer;
                            break;
                    }
                    break;
                case 7:
                    switch (Piece.Row)
                    {
                        case 1:
                            pictureBox42.Image = currentPlayer;
                            break;
                        case 2:
                            pictureBox35.Image = currentPlayer;
                            break;
                        case 3:
                            pictureBox28.Image = currentPlayer;
                            break;
                        case 4:
                            pictureBox21.Image = currentPlayer;
                            break;
                        case 5:
                            pictureBox14.Image = currentPlayer;
                            break;
                        case 6:
                            pictureBox7.Image = currentPlayer;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Error in updating column image.");
                    break;
            }

        }

        private void ResetBoard(object sender, EventArgs e)
        {
            myTable = new Table(Red, Blue);
            myTable.Set_activePlayer(Red);
            UpdateActivePlayer(myTable.Get_activePlayer());

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

        private void button1_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop(7);
        }

    }
}

