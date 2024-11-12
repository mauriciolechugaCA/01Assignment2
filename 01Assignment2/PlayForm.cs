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

namespace _01Assignment2
{
    public partial class PlayForm : Form
    {
        private PictureBox[,] gameGrid;
        private int _numRows;
        private int _numCols;
        private const int _pbCellSize = 65;
        private const int _pbCellStartRow = 300; //TODO: Change this to adjust to new position
        private const int _pbCellStartCol = 40; //TODO: Change this to adjust to new position
        //Score variables
        private int movesCount;
        private int remainingBoxes;
        //Selected box
        private PictureBox selectedBox;
        //GameController object
        private GameController gameController;

        public PlayForm()
        {
            InitializeComponent();

            gameController = new GameController(_numRows, _numCols);

            movesCount = 0;
            remainingBoxes = 0;
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
                        pbCell.Location = new Point(((j * _pbCellSize) + _pbCellStartRow), ((i * _pbCellSize) + _pbCellStartCol));

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METHOD: Movement button was pressed
        private void btnDirection_Click(object sender, EventArgs e)
        {
            //Get the button direction
            Button btnPressed = (Button)sender;
            string direction = btnPressed.Tag.ToString();

            //Check if a box is selected
            if (selectedBox == null)
            {
                MessageBox.Show("Please select a box first!");
                return;
            }

            //Move the box in the direction
            gameController.MoveBox(selectedBox, direction);

            //Update the score
            //gameController.UpdateScoreDisplay();
            //I don't need, because the MoveBox will call UpdateScoreDisplay

            //Check if the game is over
            //gameController.CheckEndGame();
            //I don't need, because the MoveBox will call CheckEndGame
        }

        //METHOD: Add border to the selected box
        //TODO: Add this click event handler to each pbCell
        private void SelectBox_Click(int row, int col)
        {
            PictureBox pbCell = gameGrid[row, col];

            //Check if the cell is a box
            if (pbCell.BackgroundImage == Properties.Resources.box_blue || pbCell.BackgroundImage == Properties.Resources.box_red)
            {
                //Add border to the box
                pbCell.BorderStyle = BorderStyle.Fixed3D;

                //Saving the selected box
                selectedBox = pbCell;
            }
            else
            {
                //MessageBox.Show("Please select a box");
            }

        }



    }
}
