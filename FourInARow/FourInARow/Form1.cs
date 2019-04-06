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
            Table myBoard = new Table(board);
        }

        Image currentPlayer;

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

        private void AnyPlayerDrop()
        {
            if (Get_activePlayer() == "Red")
            {
                Set_activePlayer("Blue");
            }
            else if (Get_activePlayer() == "Blue")
            {
                Set_activePlayer("Red");
            }
        }





















        private void button1_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AnyPlayerDrop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

