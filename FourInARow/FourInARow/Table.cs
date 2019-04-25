using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourInARow
{
    public class Table
    {
        private Player activePlayer;
        public Player Red;
        public Player Blue;

        public Table(Player r, Player b)
        {
            this.Red = r;
            this.Blue = b;
        }

        public Piece[,] Board = new Piece[10,10];
        public int[] columnWeight = new int[8];

        public int UpdateTable(int column, Player player)
        {
            if (columnWeight[column] <= 5)
            {
                Board[column, columnWeight[column]] = new Piece(player, column, columnWeight[column]);
                columnWeight[column]++;
                return 1; // return with successful peice drop.
            }
            else
            {
                return 0;
            }
        }

        public Player Get_activePlayer()
        {
            if (activePlayer.Name == "Red")
            {
                return Red;
            }
            else
            {
                return Blue;
            }
        }

        public void Set_activePlayer(Player newActivePlayer)
        {
            if (newActivePlayer.Name == "Red")
            {
                activePlayer = Red;
            }
            else if (newActivePlayer.Name == "Blue")
            {
                activePlayer = Blue;
            }

        }

        public void CheckForWin(Piece placedPiece)
        {
            //check all based on just placed peice.

        }
    }
}

