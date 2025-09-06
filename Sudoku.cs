using System;

class Program
{
    static int[,] board = {
        {5,3,0, 0,7,0, 0,0,0},
        {6,0,0, 1,9,5, 0,0,0},
        {0,9,8, 0,0,0, 0,6,0},

        {8,0,0, 0,6,0, 0,0,3},
        {4,0,0, 8,0,3, 0,0,1},
        {7,0,0, 0,2,0, 0,0,6},

        {0,6,0, 0,0,0, 2,8,0},
        {0,0,0, 4,1,9, 0,0,5},
        {0,0,0, 0,8,0, 0,7,9}
    };

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            PrintBoard();
            Console.WriteLine("Enter your move in format: row column number (1-9) or 'q' to quit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
                break;

            string[] parts = input.Split(' ');
            if (parts.Length != 3)
            {
                Console.WriteLine("Invalid input. Press any key to continue.");
                Console.ReadKey();
                continue;
            }

            if (!int.TryParse(parts[0], out int row) ||
                !int.TryParse(parts[1], out int col) ||
                !int.TryParse(parts[2], out int number))
            {
                Console.WriteLine("Invalid input. Press any key to continue.");
                Console.ReadKey();
                continue;
            }

            if (row < 1 || row > 9 || col < 1 || col > 9 || number < 1 || number > 9)
            {
                Console.WriteLine("Numbers must be between 1 and 9. Press any key to continue.");
                Console.ReadKey();
                continue;
            }

            row--; col--; // Convert to 0-based indexing

            if (board[row, col] != 0)
            {
                Console.WriteLine("Cell is already filled. Press any key to continue.");
                Console.ReadKey();
                continue;
            }

            if (IsValidMove(row, col, number))
                board[row, col] = number;
            else
            {
                Console.WriteLine("Invalid move! Press any key to continue.");
                Console.ReadKey();
            }

            if (IsBoardFull())
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine("Congratulations! You solved the Sudoku!");
                break;
            }
        }
    }

    static void PrintBoard()
    {
        for (int i = 0; i < 9; i++)
        {
            if (i % 3 == 0 && i != 0)
                Console.WriteLine("- - - + - - - + - - -");
            for (int j = 0; j < 9; j++)
            {
                if (j % 3 == 0 && j != 0)
                    Console.Write("| ");
                Console.Write(board[i, j] == 0 ? ". " : board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool IsValidMove(int row, int col, int number)
    {
        // Check row and column
        for (int i = 0; i < 9; i++)
        {
            if (board[row, i] == number || board[i, col] == number)
                return false;
        }

        // Check 3x3 box
        int startRow = (row / 3) * 3;
        int startCol = (col / 3) * 3;
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (board[startRow + i, startCol + j] == number)
                    return false;

        return true;
    }

    static bool IsBoardFull()
    {
        for (int i = 0; i < 9; i++)
            for (int j = 0; j < 9; j++)
                if (board[i, j] == 0)
                    return false;
        return true;
    }
}
