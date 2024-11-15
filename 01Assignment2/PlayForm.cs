using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        //private PlayForm form;

        public PlayForm()
        {
            InitializeComponent();

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

                Debug.WriteLine("Loadlevel finished");

                //Adding the event handler after the load
                AddClickEvent();
            }
        }

        /// <summary>
        /// Reads teh file and creates a level using the array of strings
        /// </summary>
        /// <param name="filePath"></param>
        private void LoadLevel(string filePath)
        {
            movesCount = 0;
            remainingBoxes = 0;

            if (gameGrid != null)
            {
                foreach (var pbCell in gameGrid)
                {
                    pbCell.BackgroundImage = null;
                    pbCell.Dispose();
                }
            }

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
                                pbCell.Tag = "wall";
                                break;
                            case "DR":
                                pbCell.BackgroundImage = Properties.Resources.door_red;
                                pbCell.Tag = "door_red";
                                break;
                            case "DB":
                                pbCell.BackgroundImage = Properties.Resources.door_blue;
                                pbCell.Tag = "door_blue";
                                break;
                            case "BR":
                                pbCell.BackgroundImage = Properties.Resources.box_red;
                                pbCell.Tag = "box_red";
                                remainingBoxes++;
                                //Adding the event handler to each Box
                                //pbCell.Click += (sender, e) => SelectBox_Click(i, j);
                                break;
                            case "BB":
                                pbCell.BackgroundImage = Properties.Resources.box_blue;
                                pbCell.Tag = "box_blue";
                                remainingBoxes++;
                                break;
                            default:
                                pbCell.BackgroundImage = null;
                                break;
                        }

                        gameGrid[i, j] = pbCell;

                        //Adding the event handler to each PictureBox
                        //pbCell.Click += new EventHandler(SelectBox_Click(i, j));
                        //pbCell.Click += (sender, e) => SelectBox_Click(i, j);


                        this.Controls.Add(pbCell);
                    }
                }

                //Creating the GameController object
                gameController = new GameController(_numRows, _numCols, gameGrid, remainingBoxes, this);
                Debug.WriteLine($"GameController created:_numRows: {_numRows} | _numCols: {_numCols} | remainingBoxes: {remainingBoxes} ");

                gameController.UpdateScoreDisplay();

                EnableButtons();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading level: {ex.Message}");
            }
        }

        //METHOD: Access methods to update the score. Because the GameController doesn't have access to the form
        public void UpdateMoveCount(int count)
        {
            txtNumMoves.Text = count.ToString();
        }
        public void UpdateRemainingBoxes(int count)
        {
            txtRemainingBoxes.Text = count.ToString();
        }


        //METHOD: Add the event handler to each PictureBox
        private void AddClickEvent()
        {
            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    PictureBox pbCell = gameGrid[i, j];

                    //Debug.WriteLine($"Click event check: rol: {i} | col: {j}");

                    //Only for boxes
                    //if (pbCell.BackgroundImage == Properties.Resources.box_blue || pbCell.BackgroundImage == Properties.Resources.box_red)
                    //if (pbCell.Tag == "box_red" || pbCell.Tag == "box_blue")
                    //{
                    //    //Debug.WriteLine($"Click event: rol: {i} | col: {j}");
                    //    //gameGrid[i, j].Click += (sender, e) => SelectBox_Click(i, j);
                    //    gameGrid[i, j].Click += ClickEventBox;
                    //}

                    //Needs to add the event handler to all PictureBox
                    gameGrid[i, j].Click += ClickEventBox;

                }
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

            Debug.WriteLine($"Direction: {direction}");

            //Check if a box is selected
            if (selectedBox == null)
            {
                MessageBox.Show("Please select a box first!");
                return;
            }

            //Move the box in the direction
            gameController.MoveBox(selectedBox, direction);

    
        }


        //METHOD: Call the SlectBox_Click when a Box is clicked
        private void ClickEventBox(object sender, EventArgs e)
        {
            PictureBox clickedBox = sender as PictureBox;

            //Checking if the clicked cell is a box
            if (clickedBox.Tag != "box_red" && clickedBox.Tag != "box_blue")
            {
                //Don't need to do nothing if the cell is not a box
                return;
            }

            //Searching the position of the clicked box
            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    if (gameGrid[i, j] == clickedBox)
                    {
                        //Calling the SelectBox_Click with the position
                        SelectBox_Click(i, j);
                        return;
                    }
                }
            }
        }


        //METHOD: Add border to the selected box
        private void SelectBox_Click(int row, int col)
        {
            Debug.WriteLine($"Selected: rol: {row} | col: {col}");

            PictureBox pbCell = gameGrid[row, col];

            //Check if the cell is a box
            //if (pbCell.BackgroundImage == Properties.Resources.box_blue || pbCell.BackgroundImage == Properties.Resources.box_red)
            if (pbCell.Tag == "box_red" || pbCell.Tag == "box_blue")
            {

                //Checking if a box is already selected
                if (selectedBox != null)
                {
                    //Remove the border
                    selectedBox.BorderStyle = BorderStyle.FixedSingle;
                }

                //Add border to the new selected box
                pbCell.BorderStyle = BorderStyle.Fixed3D;

                //Saving the new selected box
                selectedBox = pbCell;
            }

        }

        //METHOD: Update the selected box position
        public void UpdateSelectedBox(int newRow, int newCol)
        {

            PictureBox newCell = gameGrid[newRow, newCol];

            //Removing the border from the old cell
            selectedBox.BorderStyle = BorderStyle.FixedSingle;

            //Adding the border to the new cell
            newCell.BorderStyle = BorderStyle.Fixed3D;

            //Saving the new selected box
            selectedBox = newCell;


            selectedBox = newCell;
        }

        //METHOD: Clear the selected box
        public void ClearSelectedBox()
        {
            selectedBox.BorderStyle = BorderStyle.FixedSingle;
            selectedBox = null;
        }

        public void DisableButtons()
        {
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;

        }

        public void EnableButtons()
        {
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnLeft.Enabled = true;
            btnRight.Enabled = true;
        }

    }
}
