using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Assignment2
{
    public partial class DesignerForm : Form
    {

        private int _numRows;
        private int _numCols;
        private const int _pbCellSize = 65;

        // Matriz de PictureBoxes que representará a grade
        private PictureBox[,] gameGrid;


        public DesignerForm()
        {
            InitializeComponent();
        }

        private void btnGenerateGrid_Click(object sender, EventArgs e)
        {
            //Creating the grid with the selected size
            gameGrid = new PictureBox[_numRows, _numCols];


            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    PictureBox pbCell = new PictureBox();
                    pbCell.Width = _pbCellSize;
                    pbCell.Height = _pbCellSize;
                    pbCell.BackColor = Color.White;

                    //How to calc the location to replace i and j?. We need a logic to place the pbCell to the right location
                    pbCell.Location = new Point(320, 140);

                    //Add the pbCell to the Form
                    Controls.Add(pbCell);

                    //Add the object pbCell to the array
                    gameGrid[i,j] = pbCell;

                }
            }
        }
    }
}
