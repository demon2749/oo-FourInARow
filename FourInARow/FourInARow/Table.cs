using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourInARow
{
    class Table
    {
        public Table(TableLayoutPanel aTable)
        {
            myTable = aTable;
        }

        public TableLayoutPanel myTable;
        public int[,] myBoard = new int[6, 5];
        public int[] columnWeight = new int[6];

        public void UpdateTable(int column, string player)
        {
            if (columnWeight[column] < 5)
            {
                columnWeight[column]++;
                if (player == "Red")
                {
                    myBoard[column, columnWeight[column]] = 1;
                }
                else
                {
                    myBoard[column, columnWeight[column]] = 2;
                }
                UpdateImage(column, columnWeight[column]);
                CheckForWin(player);
            }
        }

        private void CheckForWin(string player)
        {

        }

        private void UpdateImage(int column, int row)
        {

        }
    }
}

