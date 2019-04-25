using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow
{
    public class Save
    {
        public Player activePlayer;
        public bool gameWon;
        public Piece[] Pieces = new Piece[100];
        public int[] columnWeight;

        public Save() { }

        public Save(Table t)
        {
            this.activePlayer = t.Get_activePlayer();
            this.gameWon = t.gameWon;
            this.columnWeight = t.columnWeight;

            int l = 0;
            for (int j = 0; j < 9; j++)
            {
                for (int k = 0; k < 9; k++)
                {
                    if(t.Board[j, k] != null)
                    {
                        Pieces[l] = t.Board[j, k];
                    }
                    l++;
                }
            }
        }

        public void LoadSave(Table t, Player r, Player b)
        {

            if(activePlayer.Name == r.Name)
            {
                t.Set_activePlayer(r);
            }
            else
            {
                t.Set_activePlayer(b);
            }

            t.gameWon = this.gameWon;
        }
    }
}
