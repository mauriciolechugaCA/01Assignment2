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

        public PlayForm()
        {
            InitializeComponent();
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
    }
}
