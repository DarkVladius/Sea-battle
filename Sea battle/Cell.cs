using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_battle
{
    class Cell
    {
        public Pen pen = new Pen(Color.Aqua, 3);
        public Point Location { get; set; }
        public Size CellSize { get; set; }
    }
}
