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
            //
        }

        public int[,] myBoard = new int[7, 6];
        public int[] columnWeight = new int[7];

        public int UpdateTable(int column, Player player)
        {
            if (columnWeight[column] <= 5)
            {
                myBoard[column, columnWeight[column]] = player.Id;
                columnWeight[column]++;
                return 1; // return with successful peice drop.
            }
            else
            {
                return 0;
            }
        }

        public void CheckForWin(int column, int row, Player player)
        {
            Piece placedPiece = new Piece();

            //check all based on just placed peice.
        }
    }
}

