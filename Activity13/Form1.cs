namespace Activity13
{
    public partial class Form1 : Form
    {
        //true  = x turn and false = O turn
        bool playerTurn = true; 

        //Set Count to 0
        int turnCount = 0; 


        // Creating 2D array board 
        const int ROWS = 3;
        const int COLS = 3;
        string[,] gameBoard = new string[ROWS, COLS];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Exit button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            //Button action sender based for X and O based on the clicks
            Button b = (Button)sender;
            if (playerTurn)
            
                b.Text = "X";
            else
                b.Text = "O";

            //disable the buttons of there are no sections left
            playerTurn = !playerTurn;
            b.Enabled = false;
            turnCount++;

            checkForWinner();
        }

        //Checks for winner based on the board selection
        private void checkForWinner()
        {
           
            bool gameWinner = false;
            String winner = "";

            //Row validator
            if (gameBoard[0, 0] == "X" && gameBoard[0, 1] == "X" && gameBoard[0, 2] == "X")
            {
                gameWinner = true;

            }

            if (gameBoard[0, 0] == "O" && gameBoard[0, 1] == "O" && gameBoard[0, 2] == "O")
            {
                gameWinner = true;
            }
           
            if (gameBoard[1, 0] == "X" && gameBoard[1, 1] == "X" && gameBoard[1, 2] == "X")
            {
                gameWinner = true;
            }

            if (gameBoard[1, 0] == "O" && gameBoard[1, 1] == "O" && gameBoard[1, 2] == "O")
            {
                gameWinner = true;
            }
            
            if (gameBoard[2, 0] == "X" && gameBoard[2, 1] == "X" && gameBoard[2, 2] == "X")
            {
                gameWinner = true;
            }

            if (gameBoard[2, 0] == "O" && gameBoard[2, 1] == "O" && gameBoard[2, 2] == "O")
            {
                gameWinner = true;
            }
            // Column Validator
            if (gameBoard[0, 0] == "X" && gameBoard[1, 0] == "X" && gameBoard[2, 0] == "X")
            {
                gameWinner = true;
            }

            if (gameBoard[0, 0] == "O" && gameBoard[1, 0] == "O" && gameBoard[2, 0] == "O")
            {
                gameWinner = true;
            }

            
            if (gameBoard[0, 1] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 1] == "X")
            {
                gameWinner = true;
            }

            if (gameBoard[0, 1] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 1] == "O")
            {
                gameWinner = true;
            }

            
            if (gameBoard[0, 2] == "X" && gameBoard[1, 2] == "X" && gameBoard[2, 2] == "X")
            {
                gameWinner = true;
            }
            if (gameBoard[0, 2] == "O" && gameBoard[1, 2] == "O" && gameBoard[2, 2] == "O")
            {
                gameWinner = true;
            }


            if (gameBoard[0, 0] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 2] == "X")
            {
                gameWinner = true;
            }

            if (gameBoard[0, 0] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 2] == "O")
            {
                gameWinner = true;
            }

            if (gameBoard[0, 2] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 0] == "X")
            {
                gameWinner = true;
            }
            if (gameBoard[0, 2] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 0] == "O")
            {
                gameWinner = true;
            }

            //Display an error message based on the results from the game
            if (gameWinner)
            {
                disableButtons();

                if (playerTurn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Won!");
            }
            else
            {
                if (turnCount == 9)
                    MessageBox.Show("it was a draw!");
            }

        }

        //Method to disabe the buttons if game is over
        private void disableButtons()
            {
                try
                {
                    foreach (Control c in Controls)
                    {
                        Button b = (Button)c;
                        b.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        //New game generator when game is over on a click of the button
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            playerTurn = true;
            turnCount = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
    }

    
}