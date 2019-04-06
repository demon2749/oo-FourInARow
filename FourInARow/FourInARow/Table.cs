using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourInARow
{
    class Table
    {
        public Table()
        {
            //
        }

        public int[,] myBoard = new int[7, 6];
        public int[] columnWeight = new int[7];

        public int UpdateTable(int column, string player)
        {
            if (columnWeight[column] <= 5)
            {
                if (player == "Red")
                {
                    myBoard[column, columnWeight[column]] = 1;
                }
                else
                {
                    myBoard[column, columnWeight[column]] = 2;
                }

                CheckForWin(column, columnWeight[column], player);
                columnWeight[column]++;
                // wait to update, so that [column, columnWeight[column]]
                // are the points in the array we want to update the image at.
                return 1; // return with successful peice drop.
            }
            else
            {
                return 0;
            }
        }

        public void CheckForWin(int column, int row, string player)
        {
            //check all based on just placed peice.
        }
    }
}

