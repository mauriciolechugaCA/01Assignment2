using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Assignment2
{
    internal class GameController
    {

        //Properties
        private int _numRows;
        private int _numCols;
        private PictureBox[,] gameGrid;
        private int movesCount;
        private int remainingBoxes;

        //Default Constructor
        public GameController(int rows, int cols)
        {
            _numRows = rows;
            _numCols = cols;
            movesCount = 0;
            remainingBoxes = 0;

            //Creating the grid
            gameGrid = new PictureBox[_numRows, _numCols];
        }

        ////METHOD: Load the level from the design file. Create each PictureBox and add it to the form
        //public void LoadLevel(string filePath, Control formControls)
        //{

        //}

        //METHOD: Update the score. Moves Count and Remaining Boxes
        //public void UpdateScoreDisplay()
        //{
        //    // TODO: Create labels in the form to display the score
        //    txtRemainingBoxes.Text = $"Boxes: {remainingBoxes}";
        //    txtNumMoves.Text = $"Moves: {movesCount}";
        //}

        //METHOID: Move the box to the selected direction
        public void MoveBox(PictureBox selectedBox, string direction)
        {
            //Check if the box get the door

            //Check if the box can move to the selected direction
            //CanMove();

            //Change the variables
            remainingBoxes--;
            movesCount++;

            //Update score after each valid move
            //UpdateScoreDisplay();

            //Check for end game
            CheckEndGame();
        }

        //METHOD: Check if the game is over
        private void CheckEndGame()
        {
            if (remainingBoxes == 0)
            {
                MessageBox.Show("Game Over!\nCongrats!");
                ResetGame();
            }
        }

        //METHOD: Reset the game
        private void ResetGame()
        {
            // Reset the counts
            movesCount = 0;
            remainingBoxes = 0;

            // Clear the grid
            if (gameGrid != null)
            {
                foreach (var pbCell in gameGrid)
                {
                    pbCell.BackgroundImage = null;
                    pbCell.Dispose();
                }
            }

            //txtRemainingBoxes.Text = $"Boxes: {0}";
            //txtNumMoves.Text = $"Moves: {0}";
        }

        //METHOD: Get the cell in the array
        private PictureBox GetCel(int row, int col)
        {
            //Return the PictureBox in the specified position
            return gameGrid[row, col];
        }

        //METHOD: Check if the box can move to the selected direction
        /// <summary>
        /// Check if the box can move to the selected direction
        /// </summary>
        /// <param name="box"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        private bool CanMove(PictureBox box, string direction)
        {
            // Checking if the PictureBox is a red or blue box
            if (box.BackgroundImage != Properties.Resources.box_red && box.BackgroundImage != Properties.Resources.box_blue)
            {
                return false;
            }

            // Getting the INITIAL or CURRENT row and column of the selected PictureBox
            int currentRow = -1, currentCol = -1;
            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    if (gameGrid[i, j] == box)
                    {
                        currentRow = i;
                        currentCol = j;
                        break;
                    }
                }
                if (currentRow != -1)
                {
                    break;
                }
            }

            // Getting the TARGET or FINAL row and column of the selected PictureBox
            int targetRow = currentRow, targetCol = currentCol;
            switch (direction)
            {
                case "up":
                    targetRow--;
                    break;
                case "down":
                    targetRow++;
                    break;
                case "left":
                    targetCol--;
                    break;
                case "right":
                    targetCol++;
                    break;
                default:
                    return false;
            }

            // Validating if the TARGET cell is inside the grid
            if (targetRow < 0 || targetRow >= _numRows || targetCol < 0 || targetCol >= _numCols)
            {
                return false;
            }

            // Validating if the TARGET cell is free of walls
            if (gameGrid[targetRow, targetCol].BackgroundImage == Properties.Resources.wall)
            {
                return false;
            }

            // Validating if the target cell is free of other boxes
            if (gameGrid[targetRow, targetCol].BackgroundImage == Properties.Resources.box_blue || gameGrid[targetRow, targetCol].BackgroundImage == Properties.Resources.box_red)
            {
                return false;
            }

            return true;
        }
        // METHOD: Check if the box moves to a correspoinding door
        // and returns true if the box is matching the door
        private bool IsMatchingDoor(PictureBox box, PictureBox destination)
        {
            if (box.BackgroundImage == Properties.Resources.box_red && destination.BackgroundImage == Properties.Resources.door_red)
            {
                return true;
            }
            else if (box.BackgroundImage == Properties.Resources.box_blue && destination.BackgroundImage == Properties.Resources.door_blue)
            {
                return true;
            }

            return false;
        }

    }
}
