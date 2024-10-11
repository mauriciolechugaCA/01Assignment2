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
        private const int _pbCellStartRow = 320;
        private const int _pbCellStartCol = 140;
        private Image _selectedElement = null;

        // Matriz de PictureBoxes que representará a grade
        private PictureBox[,] gameGrid;

        //Image cross = _1Assignment1.Properties.Resources.cross1;
        Image box_blue = _01Assignment2.Properties.Resources.box_blue;
        Image box_red = _01Assignment2.Properties.Resources.box_red;
        Image door_blue = _01Assignment2.Properties.Resources.door_blue;
        Image door_red = _01Assignment2.Properties.Resources.door_red;
        Image wall = _01Assignment2.Properties.Resources.wall;


        public DesignerForm()
        {
            InitializeComponent();
        }

        private void btnGenerateGrid_Click(object sender, EventArgs e)
        {
            //NEED TO ADD THE VALIDATIONS
            //Input is an integer?
            //Input is an valid number? (> 0)

            //Clean the grid if exists



            //Getting the input
            _numRows = int.Parse(textBox1.Text);
            _numCols = int.Parse(textBox2.Text);

            //Creating the grid with the selected size
            gameGrid = new PictureBox[_numRows, _numCols];

            //Loop to create the grid
            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    PictureBox pbCell = new PictureBox();

                    pbCell.Width = _pbCellSize;
                    pbCell.Height = _pbCellSize;
                    pbCell.BorderStyle = BorderStyle.FixedSingle;
                    pbCell.BackgroundImageLayout = ImageLayout.Stretch;

                    //How to calc the location to replace i and j?. We need a logic to place the pbCell to the right location
                    //pbCell.Location = new Point(320, 140);
                    pbCell.Location = new Point( ((j*_pbCellSize) + _pbCellStartRow),((i*_pbCellSize) + _pbCellStartCol) );

                    //Add the eventhandler to the pbCell
                    pbCell.Click += pictureBox1_Click;

                    //Add the pbCell to the Form
                    Controls.Add(pbCell);

                    //Add the object pbCell to the array
                    gameGrid[i,j] = pbCell;

                }
            }
        }

        private void pictureBoxWall_Click(object sender, EventArgs e)
        {
            //Copying the TicTacToe

            PictureBox clickedElement = (PictureBox)sender;

            switch(clickedElement.Name)
            {
                case "pictureBoxWall":
                    _selectedElement = wall;
                    break;
                case "pictureBoxDoorRed":
                    _selectedElement = door_red;
                    break;
                case "pictureBoxDoorBlue":
                    _selectedElement = door_blue;
                    break;
                case "pictureBoxBoxRed":
                    _selectedElement = box_red;
                    break;
                case "pictureBoxBoxBlue":
                    _selectedElement = box_blue;
                    break;
                default:
                    _selectedElement = null;
                    break;
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox clickedCell = (PictureBox)sender;

            clickedCell.BackgroundImage = _selectedElement;
        }
    }
}
