using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private PlayForm form;

        //Default Constructor
        public GameController(int rows, int cols, PictureBox[,] grid, int numOfBoxes, PlayForm form)
        {
            _numRows = rows;
            _numCols = cols;
            movesCount = 0;
            remainingBoxes = numOfBoxes;
            this.form = form;
            //Creating the grid
            //gameGrid = new PictureBox[_numRows, _numCols];
            gameGrid = grid;
        }

        ////METHOD: Load the level from the design file. Create each PictureBox and add it to the form
        //public void LoadLevel(string filePath, Control formControls)
        //{

        //}

        //METHOD: Update the score. Moves Count and Remaining Boxes
        public void UpdateScoreDisplay()
        {
            //form.txtRemainingBoxes.Text = remainingBoxes.ToString();
            //form.txtNumMoves.Text = movesCount.ToString();
            form.UpdateRemainingBoxes(remainingBoxes);
            form.UpdateMoveCount(movesCount);

        }

        //METHOID: Move the box to the selected direction
        public void MoveBox(PictureBox selectedBox, string direction)
        {

            int currentRow = -1;
            int currentCol = -1;
            string boxColor = "";

            Debug.WriteLine($"_numRows: {_numRows} | _numCols: {_numCols} | remainingBoxes: {remainingBoxes} ");

            //Get the current row and column of the selected box
            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    //Debug.WriteLine($"Loop to find the box position: iRol: {i} | jCol: {j}");
                    if (gameGrid[i, j] == selectedBox)
                    {
                        //Getting the position
                        currentRow = i;
                        currentCol = j;
                    }
                }
            }

            Debug.WriteLine($"MoveBox Current: rol: {currentRow} | col: {currentCol}");

            //Get the box color
            boxColor = selectedBox.Tag.ToString();
            //if (selectedBox.BackgroundImage == Properties.Resources.box_red)
            //{
            //    boxColor = "red";
            //}
            //else if (selectedBox.BackgroundImage == Properties.Resources.box_blue)
            //{
            //    boxColor = "blue";
            //}

            Debug.WriteLine($"MoveBox BoxColor: {boxColor}");

            //Loop to check each cell in the direction. Stop when the next cell is a wall, a box or out of limits
            int nextRow = currentRow;
            int nextCol = currentCol;

            Debug.WriteLine($"isCanMove out of while: {isCanMove(nextRow, nextCol)}");

            //Loop to check each cell in the direction. Stop when the next cell is a wall, a box or out of limits

            //Variables to store the last valid position
            int validRow = currentRow;
            int validCol = currentCol;

            //Loop to check each cell in the direction. Stop when the next cell is a wall, a box or out of limits
            //Stop only if hists the break on ifs
            while (true)
            {
                //Going to the next cell
                switch (direction)
                {
                    case "Up":
                        nextRow--;
                        break;
                    case "Down":
                        nextRow++;
                        break;
                    case "Left":
                        nextCol--;
                        break;
                    case "Right":
                        nextCol++;
                        break;
                    default:
                        break;
                }

                Debug.WriteLine($"MoveBox WHILE Next [{nextRow},{nextCol}] || Current [{currentRow},{currentCol}] || Valid [{validRow},{validCol}]");


                //Checking if the next cell is empty
                if (!isCanMove(nextRow, nextCol))
                {
                    Debug.WriteLine($"MoveBox isCanMove is false: rol: {nextRow} | col: {nextCol}");
                    break;
                }

                //Update the last valid position
                validRow = nextRow;
                validCol = nextCol;

            }

            Debug.WriteLine($"MoveBox WHILE out: {isCanMove(nextRow, nextCol)}");

            //Checking if the box was moved
            if (validRow != currentRow || validCol != currentCol)
            {
                Debug.WriteLine($"MoveBox IF the box was moved Next [{nextRow},{nextCol}] || Current [{currentRow},{currentCol}] || Valid [{validRow},{validCol}]");

                //Update the cell with the box
                gameGrid[validRow, validCol].BackgroundImage = selectedBox.BackgroundImage;
                gameGrid[validRow, validCol].Tag = selectedBox.Tag;

                //Remove the box from the current cell
                gameGrid[currentRow, currentCol].BackgroundImage = null;
                gameGrid[currentRow, currentCol].Tag = null;

                //Increase the moves count
                movesCount++;

                //Checking if the box is matching the door
                if (isMatchingDoor(validRow, validCol, boxColor))
                {
                    //Remove the box from the grid
                    gameGrid[validRow, validCol].BackgroundImage = null;
                    gameGrid[validRow, validCol].Tag = null;

                    //Decrease the remaining boxes
                    remainingBoxes--;

                }

                UpdateScoreDisplay();
            }

            CheckEndGame();

        }

        //METHOD: Check if the box can move to the selected direction
        private bool isCanMove(int row, int col)
        {
            if (row < 0 || row >= _numRows || col < 0 || col >= _numCols)
            {
                Debug.WriteLine($"isCanmove. Out of limits: rol: {row} | col: {col}");
                return false;
            }

            PictureBox cellToCheck = gameGrid[row, col];

            Debug.WriteLine($"isCanMove: rol: {row} | col: {col} | Tag: {cellToCheck.Tag}");
            //Checking if the cell is empty
            if (cellToCheck.Tag is null)
            {
                Debug.WriteLine($"isCanmove true. Empty cell: rol: {row} | col: {col}");
                return true;
            }

            Debug.WriteLine($"isCanmove false. Not empty cell: rol: {row} | col: {col}");
            return false;
        }

        //METHOD: Check if the box is matching the door. Needs to check all the direction surrounding the box
        private bool isMatchingDoor(int row, int col, string boxColor)
        {
            //Checking up. If the row is 0, outo of limits
            if (row - 1 >= 0)
            {
                //if (gameGrid[row - 1, col].Tag == "door_" + boxColor)
                //{
                //    return true;
                //}
                Debug.WriteLine($"isMatchingDoor UP: rol: {row - 1} | col: {col} | Tag: {gameGrid[row - 1, col].Tag} boxColor: {boxColor}");
                if ((boxColor == "box_blue" && gameGrid[row - 1, col].Tag == "door_blue") || (boxColor == "box_red" && gameGrid[row - 1, col].Tag == "door_red"))
                {
                    return true;
                }
            }

            //Checking down
            if (row + 1 < _numRows)
            {
                //if (gameGrid[row + 1, col].Tag == "door_" + boxColor)
                //{
                //    return true;
                //}
                Debug.WriteLine($"isMatchingDoor Down: rol: {row + 1} | col: {col} | Tag: {gameGrid[row + 1, col].Tag} boxColor: {boxColor}");
                if ((boxColor == "box_blue" && gameGrid[row + 1, col].Tag == "door_blue") || (boxColor == "box_red" && gameGrid[row + 1, col].Tag == "door_red"))
                {
                    return true;
                }
            }

            //Checking left
            if (col - 1 >= 0)
            {
                //if (gameGrid[row, col - 1].Tag == "door_" + boxColor)
                //{
                //    return true;
                //}
                Debug.WriteLine($"isMatchingDoor Left: rol: {row} | col: {col - 1} | Tag: {gameGrid[row, col - 1].Tag} boxColor: {boxColor}");
                if ((boxColor == "box_blue" && gameGrid[row, col - 1].Tag == "door_blue") || (boxColor == "box_red" && gameGrid[row, col - 1].Tag == "door_red"))
                {
                    return true;
                }
            }

            //Checking right
            if (col + 1 < _numCols)
            {
                //if (gameGrid[row, col + 1].Tag == "door_" + boxColor)
                //{
                //    return true;
                //}
                Debug.WriteLine($"isMatchingDoor Right: rol: {row} | col: {col + 1} | Tag: {gameGrid[row, col + 1].Tag} boxColor: {boxColor}");
                if ((boxColor == "box_blue" && gameGrid[row, col + 1].Tag == "door_blue") || (boxColor == "box_red" && gameGrid[row, col + 1].Tag == "door_red"))
                {
                    return true;
                }
            }

            return false;
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
        public void ResetGame()
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



    }
}
