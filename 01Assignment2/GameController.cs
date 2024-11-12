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
        public void UpdateScoreDisplay()
        {
            // TODO: Create labels in the form to display the score
            lblRemainingBoxes.Text = $"Boxes: {remainingBoxes}";
            lblMovesCount.Text = $"Moves: {movesCount}";
        }

        //METHOID: Move the box to the selected direction
        public void MoveBox(PictureBox selectedBox, string direction)
        {
            //Check if the box get the door

            //Check if the box can move to the selected direction
            CanMove();

            //Change the variables
            remainingBoxes--;
            movesCount++;

            //Update score after each valid move
            UpdateScoreDisplay();

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
            //Initialize the counts
            //Clear the grid
        }

        //METHOD: Get the cell in the array
        private PictureBox GetCel(int row, int col)
        {
            //Return the PictureBox in the specified position
            return gameGrid[row, col];
        }

        //METHOD: Check if the box can move to the selected direction
        private bool CanMove(PictureBox box, string direction)
        {
            
        }
    }
}
