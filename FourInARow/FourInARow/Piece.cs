using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow
{
    public class Piece
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public Player Player;

        public Piece(Player myPlayer, int col, int row)
        {
            this.Player = myPlayer;
            this.Column = col;
            this.Row = row;
        }

        public int Place(Table myTable)
        {
            return myTable.UpdateTable(this.Column, this.Player);
        }
    }
}
