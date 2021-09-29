using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_battle
{
    class GameField
    {
        Cell cell = new Cell(); 
        Cell[,] field = new Cell[10,10];
        public void FillGameField()
        {
            for (int y = 0; y < field.GetLength(0); y++)
            {
                for (int x = 0; x < field.GetLength(1); x++)
                {
                    field[y, x] = new Cell()
                    {
                       CellSize = new Size() 
                       { 
                       Width = 50,
                       Height = 50
                       },
                       Location = new Point()
                       {
                       X = x * 50,
                       Y = y * 50
                       }
                    };
                    
                }
            }
        }
        public void DrawCells(PaintEventArgs e)
        {
            foreach (var cell in field)
            {
                e.Graphics.DrawRectangle(cell.pen,cell.Location.X, cell.Location.Y, cell.CellSize.Height, cell.CellSize.Width);
            } 
        }
        public void PaintCell(Cell cell, PaintEventArgs g, Point location)
        {
         g.Graphics.FillRectangle(Brushes.Aqua, cell.Location.X,
         cell.Location.Y,cell.CellSize.Height, cell.CellSize.Width);
                
        }
        public void СheckingForRendering(PaintEventArgs g, Point location)
        {
            foreach (var cells in field)
            {
               if (cells.Location.X < location.X && cells.Location.X + cells.CellSize.Width < location.X
                    && cells.Location.Y < location.Y && cells.Location.Y + cells.CellSize.Height < location.Y)
                {
                    PaintCell(cells,g,location);
                }
            }
        }
    }
}
