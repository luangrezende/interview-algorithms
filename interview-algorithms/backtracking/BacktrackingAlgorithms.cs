using System.Diagnostics;

namespace interview_algorithms.backtracking
{
    public class NQueensProblem
    {
        public static void Run()
        {
            Console.WriteLine("Starting N-Queens Problem...");
            
            int n = 8; // 8x8 chessboard
            
            Stopwatch stopwatch = new();
            stopwatch.Start();
            
            var solutions = SolveNQueens(n);
            
            stopwatch.Stop();
            
            Console.WriteLine($"Found {solutions.Count} solutions for {n}-Queens problem");
            Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} ms");
            
            if (solutions.Count > 0)
            {
                Console.WriteLine("\nFirst solution:");
                PrintSolution(solutions[0], n);
            }
        }
        
        public static List<int[]> SolveNQueens(int n)
        {
            List<int[]> solutions = new List<int[]>();
            int[] positions = new int[n]; // positions[i] = column of queen in row i
            
            SolveNQueensHelper(0, positions, n, solutions);
            
            return solutions;
        }
        
        private static void SolveNQueensHelper(int row, int[] positions, int n, List<int[]> solutions)
        {
            if (row == n)
            {
                // Found a solution, add a copy to solutions
                int[] solution = new int[n];
                Array.Copy(positions, solution, n);
                solutions.Add(solution);
                return;
            }
            
            for (int col = 0; col < n; col++)
            {
                if (IsValid(positions, row, col))
                {
                    positions[row] = col;
                    SolveNQueensHelper(row + 1, positions, n, solutions);
                }
            }
        }
        
        private static bool IsValid(int[] positions, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                // Check if queens are in same column
                if (positions[i] == col)
                    return false;
                    
                // Check diagonals
                if (Math.Abs(positions[i] - col) == Math.Abs(i - row))
                    return false;
            }
            
            return true;
        }
        
        private static void PrintSolution(int[] solution, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (solution[i] == j)
                        Console.Write("Q ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
        }
    }
    
    public class Sudoku
    {
        private const int SIZE = 9;
        
        public static void Run()
        {
            Console.WriteLine("Starting Sudoku Solver...");
            
            int[,] sudoku = {
                {5, 3, 0, 0, 7, 0, 0, 0, 0},
                {6, 0, 0, 1, 9, 5, 0, 0, 0},
                {0, 9, 8, 0, 0, 0, 0, 6, 0},
                {8, 0, 0, 0, 6, 0, 0, 0, 3},
                {4, 0, 0, 8, 0, 3, 0, 0, 1},
                {7, 0, 0, 0, 2, 0, 0, 0, 6},
                {0, 6, 0, 0, 0, 0, 2, 8, 0},
                {0, 0, 0, 4, 1, 9, 0, 0, 5},
                {0, 0, 0, 0, 8, 0, 0, 7, 9}
            };
            
            Console.WriteLine("Original Sudoku:");
            PrintSudoku(sudoku);
            
            Stopwatch stopwatch = new();
            stopwatch.Start();
            
            bool solved = SolveSudoku(sudoku);
            
            stopwatch.Stop();
            
            if (solved)
            {
                Console.WriteLine("\nSolved Sudoku:");
                PrintSudoku(sudoku);
            }
            else
            {
                Console.WriteLine("\nNo solution exists for this Sudoku puzzle.");
            }
            
            Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
        
        public static bool SolveSudoku(int[,] grid)
        {
            var emptyCell = FindEmptyCell(grid);
            
            if (emptyCell == null)
                return true; // Puzzle solved
                
            int row = emptyCell.Item1;
            int col = emptyCell.Item2;
            
            for (int num = 1; num <= 9; num++)
            {
                if (IsValidMove(grid, row, col, num))
                {
                    grid[row, col] = num;
                    
                    if (SolveSudoku(grid))
                        return true;
                        
                    grid[row, col] = 0; // Backtrack
                }
            }
            
            return false;
        }
        
        private static Tuple<int, int>? FindEmptyCell(int[,] grid)
        {
            for (int row = 0; row < SIZE; row++)
            {
                for (int col = 0; col < SIZE; col++)
                {
                    if (grid[row, col] == 0)
                        return new Tuple<int, int>(row, col);
                }
            }
            return null;
        }
        
        private static bool IsValidMove(int[,] grid, int row, int col, int num)
        {
            // Check row
            for (int j = 0; j < SIZE; j++)
            {
                if (grid[row, j] == num)
                    return false;
            }
            
            // Check column
            for (int i = 0; i < SIZE; i++)
            {
                if (grid[i, col] == num)
                    return false;
            }
            
            // Check 3x3 box
            int boxRow = row - row % 3;
            int boxCol = col - col % 3;
            
            for (int i = boxRow; i < boxRow + 3; i++)
            {
                for (int j = boxCol; j < boxCol + 3; j++)
                {
                    if (grid[i, j] == num)
                        return false;
                }
            }
            
            return true;
        }
        
        private static void PrintSudoku(int[,] grid)
        {
            for (int i = 0; i < SIZE; i++)
            {
                if (i % 3 == 0 && i != 0)
                    Console.WriteLine("------+-------+------");
                    
                for (int j = 0; j < SIZE; j++)
                {
                    if (j % 3 == 0 && j != 0)
                        Console.Write("| ");
                        
                    if (grid[i, j] == 0)
                        Console.Write(". ");
                    else
                        Console.Write($"{grid[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
