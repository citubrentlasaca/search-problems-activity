using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depth_First_Search
{
    public class DepthFirstSearch
    {
        public void ExecuteSearch(string[,] grid, int rowStart, int colStart, int rowGoal, int colGoal)
        {

            int rowLength = grid.GetLength(0);
            if (rowLength == 0)
                return;
            int colLength = grid.GetLength(1);

            bool[,] visited = new bool[rowLength, colLength];
            Stack<string> stack = new Stack<string>();
            stack.Push(rowStart + "," + colStart);

            Console.WriteLine("Path:");

            while (stack.Count > 0)
            {
                string x = stack.Pop();
                int row = Int32.Parse(x.Split(",")[0]);
                int col = Int32.Parse(x.Split(",")[1]);

                if (row < 0 || col < 0 || row >= rowLength || col >= colLength || visited[row, col])
                    continue;
                if (row == rowGoal && col == colGoal)
                {
                    visited[row, col] = true;
                    Console.Write(grid[row, col] + " ");
                    // Move up
                    stack.Push((row - 1) + "," + col);
                    // Move down
                    stack.Push((row + 1) + "," + col);
                    // Move left
                    stack.Push(row + "," + (col - 1));
                    // Move right
                    stack.Push(row + "," + (col + 1));
                    break;
                }

                visited[row, col] = true;
                Console.Write(grid[row, col] + " ");
                // Move up
                stack.Push((row - 1) + "," + col);
                // Move down
                stack.Push((row + 1) + "," + col);
                // Move left
                stack.Push(row + "," + (col - 1));
                // Move right
                stack.Push(row + "," + (col + 1));
            }

            Console.WriteLine("\n");
            Console.WriteLine("Legend: \n* : Path \n- : Unvisited\n");
            Console.WriteLine("Final Grid:");
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (visited[i, j])
                    {
                        grid[i, j] = "*";
                    }
                    else if (!visited[i, j])
                    {
                        grid[i, j] = "-";
                    }
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
