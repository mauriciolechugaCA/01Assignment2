using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * Assignment 2 - PROG2370
 * 
 * Davi Henrique
 * Fernando Carvalho de Souza
 * Mauricio Lechuga
 * 
 * Due October 20th, 2024
 */

namespace _01Assignment2
{
    public partial class DesignerForm : Form
    {

        private int _numRows;
        private int _numCols;
        private const int _pbCellSize = 65;
        private const int _pbCellStartRow = 300;
        private const int _pbCellStartCol = 40;
        private Image _selectedElement = null;
        private int _countWalls;
        private int _countBoxes;
        private int _countDoors;
        private Boolean fileSaved;

        // Array to store the PictureBoxes
        private PictureBox[,] gameGrid;

        // Images to be used in the grid elements stored in the resources
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
            if (gameGrid != null)
            {
                DialogResult result = MessageBox.Show
                (
                    "Level not saved. If you proceed, the current level will be lost.\nWanto to proceed?"
                    , "Warning"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    ClearGrid();
                }
                else
                {
                    // Do nothing and keep the grid
                    return;
                }
            }

            //Getting and validating the input
            if (!ValidateInput())
            {
                return;
            }

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

                    //Calculate the position of the origin pbCell of the grid
                    pbCell.Location = new Point(((j * _pbCellSize) + _pbCellStartRow), ((i * _pbCellSize) + _pbCellStartCol));

                    //Add the eventhandler to the pbCell
                    pbCell.Click += pictureBox1_Click;

                    //Add the pbCell to the Form
                    Controls.Add(pbCell);

                    //Add the object pbCell to the array
                    gameGrid[i, j] = pbCell;

                }
            }

            //Grid edited without saving
            fileSaved = false;
        }

        private void pictureBoxWall_Click(object sender, EventArgs e)
        {
            //Copying the TicTacToe
            PictureBox clickedElement = (PictureBox)sender;

            switch (clickedElement.Name)
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

            if (_selectedElement != null)
            {
                //Change the border style of the selected element
                pictureBoxNone.BorderStyle = BorderStyle.None;
                pictureBoxWall.BorderStyle = BorderStyle.None;
                pictureBoxDoorRed.BorderStyle = BorderStyle.None;
                pictureBoxDoorBlue.BorderStyle = BorderStyle.None;
                pictureBoxBoxRed.BorderStyle = BorderStyle.None;
                pictureBoxBoxBlue.BorderStyle = BorderStyle.None;

                clickedElement.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox clickedCell = (PictureBox)sender;

            clickedCell.BackgroundImage = _selectedElement;

            //CountElements();

            //Grid edited without saving
            fileSaved = false;
        }

        /// <summary>
        /// In the file menu, save the grid and display a message box with the number of walls, doors and boxes in the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.Title = "Save grid as";
                saveFileDialog.FileName = "level.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //string filePath = saveFileDialog.FileName;
                    SaveToFile(saveFileDialog.FileName);

                    CountElements();
                    DisplaySuccessMessage();

                    fileSaved = true;
                }
            }
        }

        /// <summary>
        /// Counts how many wall, doors and boxes are in the grid
        /// </summary>
        private void CountElements()
        {
            _countBoxes = 0;
            _countDoors = 0;
            _countWalls = 0;

            foreach (var item in gameGrid)
            {
                if (item.BackgroundImage != null)
                {
                    //switch(item.BackgroundImage.ToString())
                    //{
                    //    case "wall":
                    //        _countWalls++;
                    //        break;
                    //    case "door_red":
                    //    case "door_blue":
                    //        _countDoors++; 
                    //        break;
                    //    case "box_red":
                    //    case "box_blue":
                    //        _countBoxes++;
                    //        break;
                    //}
                    if (item.BackgroundImage == wall)
                    {
                        _countWalls++;
                    }
                    else if (item.BackgroundImage == door_red || item.BackgroundImage == door_blue)
                    {
                        _countDoors++;
                    }
                    else if (item.BackgroundImage == box_red || item.BackgroundImage == box_blue)
                    {
                        _countBoxes++;
                    }
                }
            }

            Console.WriteLine($"Boxes: {_countBoxes} | Doors: {_countDoors} | Walls: {_countWalls}");
        }

        /// <summary>
        /// Display a message box with the number of walls, doors and boxes in the grid
        /// </summary>
        private void DisplaySuccessMessage()
        {
            string msg = $"File saved successfully!\n" +
                         $"Total Number o walls: {_countWalls}\n" +
                         $"Total Number o doors: {_countDoors}\n" +
                         $"Total Number o boxes: {_countBoxes}\n";

            MessageBox.Show(msg);
        }

        /// <summary>
        /// If the grid is not saved, ask the user if he wants to proceed with the close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Check if the grid is saved
            if (fileSaved)
            {
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show
                    (
                        "Level not saved. If you proceed, the current level will be lost.\nWanto to proceed?"
                        , "Warning"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Warning
                    );
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Validate the input from the user to make sure it is a valid integer between 1 and 10
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            int num1, num2;
            bool isNum1Valid = int.TryParse(textBox1.Text, out num1);
            bool isNum2Valid = int.TryParse(textBox2.Text, out num2);

            // Check if input is an integer
            if (!isNum1Valid || !isNum2Valid)
            {
                MessageBox.Show("Please enter an integer number between 1 and 10");
                return false;
            }
            // Check if input is between 1 and 10
            else if (num1 < 1 || num1 > 10 || num2 < 1 || num2 > 10)
            {
                MessageBox.Show("Please enter a number between 1 and 10");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Clear the grid and dispose the PictureBoxes
        /// </summary>
        private void ClearGrid()
        {
            if (gameGrid != null)
            {
                foreach (var pbCell in gameGrid)
                {
                    pbCell.BackgroundImage = null;
                    Controls.Remove(pbCell);
                    pbCell.Dispose();
                }
            }
            gameGrid = null;
        }

        /// <summary>
        /// Save the grid to a txt file
        /// </summary>
        /// <param name="filePath"></param>

        // Serialize the grid to a file
        private void SaveToFile(string filePath)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    if (gameGrid[i, j].BackgroundImage == wall)
                    {
                        sb.Append("W"); // W for Wall
                    }
                    else if (gameGrid[i, j].BackgroundImage == door_red)
                    {
                        sb.Append("DR"); // DR for Door Red
                    }
                    else if (gameGrid[i, j].BackgroundImage == door_blue)
                    {
                        sb.Append("DB"); // DB for Door Blue
                    }
                    else if (gameGrid[i, j].BackgroundImage == box_red)
                    {
                        sb.Append("BR"); // BR for Box Red
                    }
                    else if (gameGrid[i, j].BackgroundImage == box_blue)
                    {
                        sb.Append("BB"); // BB for Box Blue
                    }
                    else
                    {
                        sb.Append("E"); // E for Empty
                    }

                    if (j < _numCols - 1)
                    {
                        sb.Append(","); 
                    }
                }
                sb.AppendLine(); 
            }

            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
