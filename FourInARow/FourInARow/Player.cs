using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FourInARow
{
    public class Player
    {
        public string Name { get; set; }
        public Image Picture { get; set; }

        public Player() { }

        public Player(string name, Image picture)
        {
            this.Name = name;
            this.Picture = picture;
        }

    }
}