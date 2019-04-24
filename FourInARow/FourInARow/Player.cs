using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow
{
    class Player
    {
        string name { get; set; }
        Image picture { get; set; }

        public Player(string name, Image picture)
        {
            this.name = name;
            this.picture = picture;
        }

    }
}
