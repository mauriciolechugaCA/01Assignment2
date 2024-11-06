using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01Assignment2;

// MOVEMENT NOT WORKING YET

namespace _01Assignment2
{
    public partial class PlayForm : Form
    {
        private PictureBox[,] gameGrid;
        private int _numRows;
        private int _numCols;
        private const int _pbCellSize = 65;
        private const int _pbCellStartRow = 40; // TODO: Change this to adjust to new position
        private const int _pbCellStartCol = 20; // TODO: Change this to adjust to new position
        private PictureBox selectedBox = null;

        // Images to be used in the grid elements stored in the resources
        Image box_blue = _01Assignment2.Properties.Resources.box_blue;
        Image box_red = _01Assignment2.Properties.Resources.box_red;
        Image door_blue = _01Assignment2.Properties.Resources.door_blue;
        Image door_red = _01Assignment2.Properties.Resources.door_red;
        Image wall = _01Assignment2.Properties.Resources.wall;


        public PlayForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void loadLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadLevel(filePath);
            }
        }

        /// <summary>
        /// Reads teh file and creates a level using the array of strings
        /// </summary>
        /// <param name="filePath"></param>
        private void LoadLevel(string filePath)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                _numRows = lines.Length;
                _numCols = lines[0].Split(',').Length;

                // Initializing the grid with the file data
                gameGrid = new PictureBox[_numRows, _numCols];

                for (int i = 0; i < _numRows; i++)
                {
                    string[] cells = lines[i].Split(',');

                    for (int j = 0; j < _numCols; j++)
                    {
                        PictureBox pbCell = new PictureBox();

                        pbCell.Width = _pbCellSize;
                        pbCell.Height = _pbCellSize;
                        pbCell.BorderStyle = BorderStyle.FixedSingle;
                        pbCell.BackgroundImageLayout = ImageLayout.Stretch;
                        pbCell.Location = new Point(((j * _pbCellSize) + _pbCellStartCol), ((i * _pbCellSize) + _pbCellStartRow));

                        switch (cells[j])
                        {
                            case "W":
                                pbCell.BackgroundImage = Properties.Resources.wall;
                                break;
                            case "DR":
                                pbCell.BackgroundImage = Properties.Resources.door_red;
                                break;
                            case "DB":
                                pbCell.BackgroundImage = Properties.Resources.door_blue;
                                break;
                            case "BR":
                                pbCell.BackgroundImage = Properties.Resources.box_red;
                                break;
                            case "BB":
                                pbCell.BackgroundImage = Properties.Resources.box_blue;
                                break;
                            default:
                                pbCell.BackgroundImage = null;
                                break;
                        }

                        // Add MouseClick event to the PictureBox
                        pbCell.MouseClick += PbCell_MouseClick;

                        gameGrid[i, j] = pbCell;
                        this.Controls.Add(pbCell);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading level: {ex.Message}");
            }
        }

        private void PbCell_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pbCell = (PictureBox)sender;

            if (pbCell.BackgroundImage == box_blue || pbCell.BackgroundImage == box_red)
            {
                selectedBox.BorderStyle = BorderStyle.FixedSingle;
            }

            selectedBox = pbCell;
            selectedBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Listens for key presses in order to move the selected box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    MoveSelectedBox("Up");
                    break;
                case Keys.Down:
                case Keys.S:
                    MoveSelectedBox("Down");
                    break;
                case Keys.Left:
                case Keys.A:
                    MoveSelectedBox("Left");
                    break;
                case Keys.Right:
                case Keys.D:
                    MoveSelectedBox("Right");
                    break;
                default:
                    break;
            }
        }

        private void MoveSelectedBox(string direction)
        {
            PictureBox selectedBox = null;

            if (selectedBox == null)
            {
                MessageBox.Show("Go select a box!");
                return;
            }

            switch (direction)
            {
                case "Up":
                    MoveBox(selectedBox, 0, -1);
                    break;
                case "Down":
                    MoveBox(selectedBox, 0, 1);
                    break;
                case "Left":
                    MoveBox(selectedBox, -1, 0);
                    break;
                case "Right":
                    MoveBox(selectedBox, 1, 0);
                    break;
            }
        }

        private void MoveBox(PictureBox box, int deltaX, int deltaY)
        {
            int currentRow = (box.Top - _pbCellStartRow) / _pbCellSize;
            int currentCol = (box.Left - _pbCellStartCol) / _pbCellSize;

            int newRow = currentRow + deltaY;
            int newCol = currentCol + deltaX;

            // Ensure the new position is within the grid bounds
            if (newRow >= 0 && newRow < _numRows && newCol >= 0 && newCol < _numCols)
            {
                // Move the box to the new position
                box.Location = new Point((newCol * _pbCellSize) + _pbCellStartCol, (newRow * _pbCellSize) + _pbCellStartRow);
            }
        }
    }
}
