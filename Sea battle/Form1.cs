using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_battle
{
    public partial class Form1 : Form
    {
        PaintEventArgs c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameField gf = new GameField();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            c = e;
            GameField gf = new GameField();
            gf.FillGameField();
            gf.DrawCells(e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            GameField gf = new GameField();
            gf.СheckingForRendering(c, e.Location);
        }
    }
}
