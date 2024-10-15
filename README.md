# Black Hole Game

## DESIGN

### Class Variables
	* int numRows
	* int numCols
	* PictureBox[,] gameGrid
	* int pbCellSize
	* int pbCellStartRow
	* int pbCellStartCol
	
### EventHandler Generate_Click
	* Get the inputs and do the validations
	* 2 for loops
		- 1 for Rows and 1 for Cols
	* Each Col, create a PictureBox
		- Change the size
		- Define the location (How?)
		- StartLocation = (320,140)
		- Change the BorderStyle
		- Add the click event to the pbCell
		- Add the pbCell to the form
		- Add the pbCell to the array

### EventHandler pictureBoxWall_Click
	* Get the name propertie after an element is clicked
	
### EventHandler pictureBox1_Click
	* Add the selected BackgroundImage to the clicked cell
	
### EventHandler saveToolStripMenuItem_Click
	* Save the generated grid to a file
		- Show the "Save As" menu
			- Can change the filename
			- Choose the folder to save
	* Display a messagebox if OK
		- DisplaySuccessMessage()
	* Close the DesignerForm (???)
	
### Method CountElements
	* Will return the number of walls, doors and boxes
	* Read the entire array and count the elements
	
### Method DisplaySuccessMessage
	* Display a messagebox
		- "File saved successfully"
		- Total number of walls: X
		- Total number of doors: X
		- Total number of boxes: X
	* CountElements()

### ValidateInput
	* Returns true if conditions met
	* Only allows integers between 1 and 10
 	* Pops a message box with an error

### ClearGrid
	* Clears the grid of any images

### SaveToFile
	* Using loops, we serialize each cell and assign a value that appends to a text file 
		
