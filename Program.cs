using System;

namespace Connect4Game
{
    class GameGrid // This is to define our Grid for the game. We opted for a 6 by 7
    {
       private char[,] grid;
       private int rows = 6;
       private int cols = 7;

       public GameGrid()
{
        grid = new char[rows, cols];
        for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < cols; c++)
        {
            grid[r, c] = '.';
        }
    }
}


        public void DropPiece(int col, char piece)
        {
             for (int r = rows - 1; r >= 0; r--)
        {
     if (grid[r, col] == '.')
        {
         grid[r, col] = piece;
     } }
           
        }

        private bool CheckLine(int r, int c, char piece) //
        {
            return CheckDirection(r, c, piece, 1, 0) || // Horizontal
                   CheckDirection(r, c, piece, 0, 1) || // Vertical
                   CheckDirection(r, c, piece, 1, 1) || // Diagonal /
                   CheckDirection(r, c, piece, 1, -1);  // Diagonal \
        }

         private bool CheckDirection()
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                int newRow = r + i * rDir;
                int newCol = c + i * cDir;
                if (newRow < 0 || newRow >= rows || newCol < 0 || newCol >= cols || grid[newRow, newCol] != piece)
                {
                    break;
                }
                count++;
            }
            return count == 4;
        }
        
        private bool CheckWin()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (grid[r, c] == piece)
                    {
                        if (CheckLine(r, c, piece))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
       
        public void DisplayGrid()
        {
           for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < cols; c++)
        {
            Console.Write(grid[r, c] + " ");
        }
        Console.WriteLine();
    }

    // Display column numbers at the bottom
    for (int c = 0; c < cols; c++)
    {
        Console.Write(c + " ");
    }
    Console.WriteLine();
        }

        public bool IsColumnFull(int col)
        {
        return grid[0, col] != '.';
        }
    }

    class GameMaster
    {
        
        public void StartGame()
        {
         
      
        }

        private void PlayGame()
        {
            
        }

        private void PlayerTurn(bool isPlayer1)
        {
           
        }

        public void Winner()
        {
          
        }
    }

    abstract class Player // created an abstract class of Player in case we want to add AI
    {
    protected char piece;
    public Player(char piece)
  {
      this.piece = piece;
  }

     public abstract void TakeTurn(GameGrid grid);
    }

    class HumanPlayer : Player
    {
        public override void TakeTurn()
        {
            
        }
    }


    class Program
    {
         static void Main(string[] args)
        {
    
        }
    }
}
