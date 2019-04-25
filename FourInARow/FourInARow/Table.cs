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
        public Table()
        {
            // do nothing in particular.
        }

        public Piece[,] Board = new Piece[8,7];
        public int[] columnWeight = new int[7];

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

        public void CheckForWin(Piece placedPiece)
        {
            //check all based on just placed peice.

        }
    }
}

