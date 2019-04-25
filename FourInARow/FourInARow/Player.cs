using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow
{
    public class Player
    {
        public string Name { get; set; }
        public Image Picture { get; set; }
        public int Id { get; set; }

        public Player(string name, Image picture, bool isActive)
        {
            this.Name = name;
            this.Picture = picture;
        }

    }
}
