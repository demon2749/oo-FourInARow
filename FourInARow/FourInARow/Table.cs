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
        public bool gameWon = false;

        public Piece[,] Board = new Piece[10, 10];
        public int[] columnWeight = new int[10];

        public Table() { }

        public Table(Player r, Player b)
        {
            this.Red = r;
            this.Blue = b;
            for(int i = 0; i<=9; i++)
            {
                columnWeight[i] = 1;
            }
        }

        public bool UpdateTable(int column, Player player)
        {
            if (columnWeight[column] <= 6)
            {
                Board[column, columnWeight[column]] = new Piece(player, column, columnWeight[column]);
                columnWeight[column]++;
                return true; // return with successful peice drop.
            }
            else
            {
                return false;
            }
        }

        public Player Get_activePlayer()
        {
            if (activePlayer.Name == Red.Name)
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
            if (newActivePlayer.Name == Red.Name)
            {
                activePlayer = Red;
            }
            else if (newActivePlayer.Name == Blue.Name)
            {
                activePlayer = Blue;
            }

        }

        public bool CheckForWin(Piece placedPiece)
        {

            // VERTICAL ----------------------------------------------------------------------------------
            int vert = 1;
            for (int i = placedPiece.Row - 1; i >= 1 && Board[placedPiece.Column, i] != null; i--)
            {
                if (Board[placedPiece.Column, i].Player.Name == placedPiece.Player.Name)
                {
                    vert++;
                }
                else
                {
                    break;
                }
            }

            // HORIZONTAL --------------------------------------------------------------------------------
            int horiz = 1;
            for (int i = placedPiece.Column - 1; i >= 1 && Board[i, placedPiece.Row] != null; i--)
            {
                if (Board[i, placedPiece.Row].Player.Name == placedPiece.Player.Name)
                {
                    horiz++;
                }
                else
                {
                    break;
                }
            }
            for (int i = placedPiece.Column + 1; i <= 7 && Board[i, placedPiece.Row] != null; i++)
            {
                if (Board[i, placedPiece.Row].Player.Name == placedPiece.Player.Name)
                {
                    horiz++;
                }
                else
                {
                    break;
                }
            }

            // DIAGONAL 1 (Bottom left to top right) -----------------------------------------------------

            int diag1 = 1;

            int j = placedPiece.Column - 1;
            int k = placedPiece.Row - 1;
            while (j >= 1 && k >= 1 && Board[j, k] != null)
            {
                if (Board[j, k].Player.Name == placedPiece.Player.Name)
                {
                    diag1++;
                }
                else
                {
                    break;
                }
                j--;
                k--;
            }

            j = placedPiece.Column + 1;
            k = placedPiece.Row + 1;
            while (j <= 7 && k <= 6 && Board[j, k] != null)
            {
                if (Board[j, k].Player.Name == placedPiece.Player.Name)
                {
                    diag1++;
                }
                else
                {
                    break;
                }
                j++;
                k++;
            }

            // DIAGONAL 2 (Top left to bottom right) -----------------------------------------------------

            int diag2 = 1;

            j = placedPiece.Column - 1;
            k = placedPiece.Row + 1;
            while (j >= 1 && k <= 6 && Board[j, k] != null)
            {
                if (Board[j, k].Player.Name == placedPiece.Player.Name)
                {
                    diag2++;
                }
                else
                {
                    break;
                }
                j--;
                k++;
            }

            j = placedPiece.Column + 1;
            k = placedPiece.Row - 1;
            while (j <= 7 && k >= 1 && Board[j, k] != null)
            {
                if (Board[j, k].Player.Name == placedPiece.Player.Name)
                {
                    diag2++;
                }
                else
                {
                    break;
                }
                j++;
                k--;
            }

            // -------------------------------------------------------------------------------------------

            // Debug ---
            //Console.WriteLine();
            //Console.WriteLine("Placed a " + placedPiece.Player.Name + " Piece at " + placedPiece.Column + ", " + placedPiece.Row + ".");
            //Console.WriteLine(vert + " vertical | " + horiz + " horizontal | " + diag1 + " ascending | " + diag2 + " decending");

            if (vert > 3 || horiz > 3 || diag1 > 3 || diag2 > 3)
            {
                Console.WriteLine(placedPiece.Player.Name + " Won!");
                gameWon = true;
                return true;
            }

            return false;
        }
    }
}

