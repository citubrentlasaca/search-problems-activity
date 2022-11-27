using Depth_First_Search;

string[,] grid = { {"1", "2", "3", "4", "5"},
                {"6", "7", "8", "9", "10"},
                {"11", "12", "13", "14", "15"},
                {"16", "17", "18", "19", "20"},
                {"21", "22", "23", "24", "25"}};

Console.Write("Enter Start Row (0-4): ");
int startRow = Int32.Parse(Console.ReadLine());
Console.Write("Enter Start Column (0-4): ");
int startCol = Int32.Parse(Console.ReadLine());
Console.Write("Enter Goal Row (0-4): ");
int goalRow = Int32.Parse(Console.ReadLine());
Console.Write("Enter Goal Column (0-4): ");
int goalCol = Int32.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Initial Grid:");
for (int i = 0; i < grid.GetLength(0); i++)
{
    for (int j = 0; j < grid.GetLength(1); j++)
    {
        Console.Write(grid[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

DepthFirstSearch dfs = new DepthFirstSearch();
dfs.ExecuteSearch(grid, startRow, startCol, goalRow, goalCol);