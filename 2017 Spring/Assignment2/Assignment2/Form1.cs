using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        const int ROWS = 4;        // Constant for rows on game board 
        const int COLS = 4;        // Constant for columns on game board 

        // String array signifies the board. It holds the background color of the labels.
        // "ControlLight" = User has not clicked
        // "Blue" = water
        // "Red" = Horizontal ship
        // "Black" = Vertical ship   
        private String[,] board = new string[ROWS, COLS];

        // Constant to hold the number of ships       
        const int SHIP_QTY = 2;      
        
        // Constant to hold two ROW, COl coordinates for each ship                   
        const int SHIP_SIZE =4;

        // 2D Int array, SHIP_QTY used to denote a ship and SHIP_SIZE used to
        // hold the coordinates of the ship as {ROW, COL, ROW, COL}.
        private int[,] Ships = new int[SHIP_QTY,SHIP_SIZE];

        int redShip;            // accumulator to show how many times the red ship has been "HIT"
        int blackShip;          // accumulator to show how many times the black ship has been "HIT"
        int tries;              // accumulator to show how many times the player has clicked on the board
        
        // Flag to check if game is over. False = game is in play. True = game is over
        Boolean gameOver = false;


        /// <summary>
        ///   Form1() is used to play a single player version of battleship. The game is played on a 4 x 4 board
        ///   and the player must find the two hidden ships in the least amount of moves. The game finishes when the
        ///   player has found both of the ships. 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// StartGame() method readies the program for a new game by calling methods to clear the game variables
        ///   reset the board colors, get new ship locations and display the new game to the user. 
        /// </summary>
        private void StartGame()
        {
            ResetMarkers();
            ClearBoard(board);
            SetShipLoc(Ships);
            DrawBoard();
            
            
        }

        /// <summary>
        /// resetMarkers() clears the game variables by zeroing out the amount of times a ship has been hit,
        /// zeroing out the amount of times a player has moved, setting the gameOver flag to false (meaning the
        /// game is still in play) and clearing the result label.
        /// </summary>
        private void ResetMarkers()
        {
            redShip=0;
            blackShip=0;
            tries=0;
            gameOver = false;
            resultLabel.Text = "";
        }

        /// <summary>
        /// The ClearBaord() method sets the background color of every board location to 
        /// "ControlLight". Which represents an area where the player has not clicked on.
        /// <param name="array">Receives a 2D string array that represents the game board. </param>
        /// </summary>
        private void ClearBoard(String[,] array)
        {
            for (int r = 0; r < ROWS; r++)
                for (int c = 0; c < COLS; c++)
                {
                    array[r, c] = "ControlLight";                    
                }
        }

        /// <summary>
        /// The DrawBoard() method uses the 2D board array to set the background color of each label
        /// on the board. It reads the board and sets each label background color directly.   
        /// </summary>
        private void DrawBoard()
        {
            for (int r = 0; r < ROWS; r++)
                for (int c = 0; c < COLS; c++)
                {
                    String labelName = "label" + r + c;      // Creates the name of the label 
                    
                    //Use the name of the label to get a reference for the label using Controls.Find().
                    //Then use the color as a string from the board to update the bacground color using
                    // Color.FromName().
                    ((Label)Controls.Find(labelName, true)[0]).BackColor = Color.FromName(board[r, c]);
                }
        }

        /// <summary>
        /// the UpdateBoard() method uses the row and column received from user input to update the
        /// game board (array). It checks to see if the user has already clicked on that location or
        /// if the game is over. The method returns false and does not update the board if the gameOver
        /// flag is set to true. If the location has the color "ControlLight"It calls the IsShipLoc() 
        /// method to check if the location has a ship as this means the user has previously clicked 
        /// this location. The number of tries(Moves) is incremented to signify that a move was made.
        /// IsShipLoc returns true if there is a ship and assigns the ship number to the variable "ship". 
        /// Ship is then used to change the color to Red(Horizontal) or Black(Vertical).
        /// If isShipLoc returns false the board location is set to the color "Blue".  
        /// </summary>
        /// <param name="array">Receives a 2D string array that represents the game board. </param>
        /// <param name="row">Receives an int from label user click event</param>
        /// <param name="col"> Receives an int from label user click even</param>
        /// <returns></returns>
        private Boolean UpdateBoard(String[,] array,int row, int col)
        {
            
            
            //Check if board location has been previously clicked or if the game is over
            if (array[row, col] != "ControlLight" || gameOver == true)
                return false;

            tries++;                //If the game is not over, increment the tries variable.
            int ship;     // Holds the number of the ship returned by IsShipLoc().

            //Check if the board location has a ship, if so return the ship number
            if (IsShipLoc(row, col, out ship))
            {
               
                if (ship == 0)       // Ship "0" is the horiontal ship.              
                {
                    array[row, col] = "Red"; // Set background to red for board location.

                    // Increment the redShip variable (number of times red ship has been hit)
                    redShip++;          
                }
                else if (ship == 1)     // Ship "1" is the Vertical ship.   
                {
                    array[row, col] = "Black"; // Set background to black for board location.

                    // Increment the blackShip variable (number of times black ship has been hit)
                    blackShip++;
                }                    
            }
            else array[row, col] = "Blue";    //There is no ship in this location. Set Background to blue.
            return true;                      //Return true as a move was made.

        }

        /// <summary>
        /// IsShipLoc receives two int variables to signify a location on the game board. It is used
        /// when the program needs to know if there is a ship in that location but which ship is not
        /// needed. It calls its overloeaded method which returns true/false if there is a ship and the
        /// ship number. The ship number is discarded and only true/false is returned.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        private bool IsShipLoc(int row, int col)
        {
            int ship;
            return IsShipLoc(row, col, out ship);
        }

        /// <summary>
        /// IsShipLoc() is an overloaded method that returns true/false and a ship location as an int. It
        /// checks to see if the row/col combination exists in the 2D array Ships[,] which holds the location
        /// of the ships. If there is a match, the method returns true and which ship was found.
        /// </summary>
        /// <param name="row">used to check against ship locations</param>
        /// <param name="col">used to check against ship locations</param>
        /// <param name="ship">used to return which ship was found</param>
        /// <returns></returns>
        private bool IsShipLoc(int row, int col, out int ship)
        {
            // Test if row/col is in the first ship
            if (row == Ships[0, 0] && col == Ships[0, 1]) 
            {
                // row/col match, set ship to 0 and return true.
                ship = 0;             
                return true;
            }    
                        
            if (row == Ships[0, 2] && col == Ships[0, 3])
            {
                // row/col match, set ship to 0 and return true.
                ship = 0;
                return true;
            }
            // Test if row/col is in the Second ship  
            if (row == Ships[1, 0] && col == Ships[1, 1])
            {
                // row/col match, set ship to 1 and return true.
                ship = 1;
                return true;
            }
                
            if (row == Ships[1, 2] && col == Ships[1, 3])
            {
                // row/col match, set ship to 1 and return true.
                ship = 1;
                return true;
            }
            ship = -1;      // Must set ship, will be discarded.
            return false;   // No match found, row/col location was not a ship
        }

        /// <summary>
        /// setShipLoc receives a 2D array that is used to hold the location of 2 ships on
        /// the board. It then randomly generates a location for the first ship(horizontal). The second
        /// ship(vertical) is randomly generated but then checked against the location of the first ship.
        /// If the randomly generated location of the second ship conflicts with the first ship, then a 
        /// new location is generated.
        /// </summary>
        /// <param name="ships">2D array to hold ship locations</param>
        private void SetShipLoc(int[,] ships)
        {
            
            //Create a Random object generator
            Random rand = new Random();
            
            //Set random horizontal ship location
            int row = rand.Next(ROWS);
            int col = rand.Next(COLS);
            
            // Set the first location if the ship
            ships[0, 0] = row;
            ships[0, 1] = col;
            // Set the row of the second location of the ship (Must match) 
            ships[0, 2] = row;
            
            // Set the column of the second location of the ship based on the
            // column of the first location.
            if (ships[0, 1] == 3) 
            {
                ships[0, 3] = 2;
            }
            if (ships[0, 1] == 0)
            {
                ships[0, 3] = 1;
            }
            if (ships[0, 1] == 1)
                ships[0, 3] = 2;
            if (ships[0, 1] == 2)
                ships[0, 3] = 1;
            
            // Variables to hold second ship location.
            int ship2row1;
            int ship2col1;
            int ship2row2;
            int ship2col2;

            // do-while loop to check if second ship is in
            // conflict with first ships location.
            do
            {
                //Get random first location of second ship
                ship2row1 = rand.Next(ROWS);
                ship2col1 = rand.Next(COLS);

                // Variable to hold second location
                ship2row2 = 0;
                // Set column to first location. Columns must match.
                ship2col2 = ship2col1;   
                // Set row of second location based on row of first location.
                if (ship2row1 == 3)
                {
                    ship2row2 = 2;
                }
                if (ship2row1 == 0)
                {
                    ship2row2 = 1;
                }
                if (ship2row1 == 1)
                    ship2row2 = 2;
                if (ship2row1 == 2)
                    ship2row2 = 1;
                //Test to make sure second ship locations do not conflict with first ship.
            } while (IsShipLoc(ship2row1, ship2col1) || IsShipLoc(ship2row2, ship2col2)); 

            //Set second ship location in ships[,] array.
            ships[1, 0] = ship2row1;
            ships[1, 1] = ship2col1;
            ships[1, 2] = ship2row2;
            ships[1, 3] = ship2col2;           
        }

        /// <summary>
        /// PlayMove() receives a board location from a click event which it uses to play the game.
        /// it calls the UpdateBoard() method to see if a move can be made. If no move can be made
        /// the method ends. If a move was made, the DrawBoard() method is called to display the
        /// board to the player. The CheckWon() method is called to see if both the ships have been 
        /// found. If both ships have been found the EndGame() method is called to end the game.
        /// </summary>
        /// <param name="row">received from click event, signifies location on board.</param>
        /// <param name="col">received from click event, signifies location on board.</param>
        private void PlayMove(int row, int col)
        {

            if (!UpdateBoard(board, row, col)) return; //Check if move can be made
            DrawBoard();            //Move was made, display new board.
            if (CheckWon())         //Check if game was won
                EndGame();          //Game was won, end the game.
        }

        /// <summary>
        /// EndGame() method sets the boolean variable gameOver to true and displays
        /// the number of moves to the result label. 
        /// </summary>
        private void EndGame()
        {
            gameOver = true;
            resultLabel.Text = "You won in " + tries + " moves!";
            
        }

        /// <summary>
        /// CheckWon() method checks if both the ships have been found. If both ships are found
        /// then it returns true, otherwise it returns false.
        /// </summary>
        /// <returns></returns>
        private Boolean CheckWon()
        {
            if (redShip == 2 && blackShip == 2)  //Check to see if both ships are found
                return true;        
            return false;
        }
        /// <summary>
        /// startButton_Click() is an event handler for the "Start" button. If pressed it begins
        /// a new game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void startButton_Click(object sender, EventArgs e)
        {
            StartGame();
            
        }

        private void label00_Click(object sender, EventArgs e)
        {
            PlayMove(0, 0);
        }

 

        private void label01_Click(object sender, EventArgs e)
        {
            PlayMove(0, 1);
        }

        private void label02_Click(object sender, EventArgs e)
        {
            PlayMove(0, 2);
        }

        private void label03_Click(object sender, EventArgs e)
        {
            PlayMove(0, 3);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            PlayMove(1, 0);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            PlayMove(1, 1);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            PlayMove(1, 2);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            PlayMove(1, 3);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            PlayMove(2, 0);
        }

        private void label21_Click(object sender, EventArgs e)
        {
            PlayMove(2, 1);
        }

        private void label22_Click(object sender, EventArgs e)
        {
            PlayMove(2, 2);
        }

        private void label23_Click(object sender, EventArgs e)
        {
            PlayMove(2, 3);
        }

        private void label30_Click(object sender, EventArgs e)
        {
            PlayMove(3, 0);
        }

        private void label31_Click(object sender, EventArgs e)
        {
            PlayMove(3, 1);
        }

        private void label32_Click(object sender, EventArgs e)
        {
            PlayMove(3, 2);
        }

        private void label33_Click(object sender, EventArgs e)
        {
            PlayMove(3, 3);
        }

        /// <summary>
        /// Form1_Load() begins a new game when the form is loaded by calling the
        /// StartGame() method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
             StartGame();
        }
    }
}
