using System;
using System.Collections.Generic;

class MainClass
{

    public static int BitmapHoles(string[] strArr)
    {
        int count = 0;
        int numRows = strArr.Length;
        int numCols = strArr[0].Length;
        bool[,] visited = new bool[numRows, numCols];

        //percorre a matriz com um loop duplo e verifica cada célula para ver se ela é um 0 e se ainda não foi visitada.
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                if (strArr[i][j] == '0' && !visited[i, j])
                {
                    BFS(i, j, strArr, visited);
                    count++;
                }
            }
        }

        return count;
    }

    // responsável por fazer a busca em largura | BFS (Breadth-First Search) 
    private static void BFS(int row, int col, string[] strArr, bool[,] visited)
    {
        int numRows = strArr.Length;
        int numCols = strArr[0].Length;
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        queue.Enqueue(new Tuple<int, int>(row, col));
        visited[row, col] = true;

        while (queue.Count > 0)
        {
            Tuple<int, int> current = queue.Dequeue();
            int currentRow = current.Item1;
            int currentCol = current.Item2;

            //verifica cada posições
            if (currentRow > 0 && strArr[currentRow - 1][currentCol] == '0' && !visited[currentRow - 1, currentCol])
            {
                queue.Enqueue(new Tuple<int, int>(currentRow - 1, currentCol));
                visited[currentRow - 1, currentCol] = true;
            }
            if (currentRow < numRows - 1 && strArr[currentRow + 1][currentCol] == '0' && !visited[currentRow + 1, currentCol])
            {
                queue.Enqueue(new Tuple<int, int>(currentRow + 1, currentCol));
                visited[currentRow + 1, currentCol] = true;
            }
            if (currentCol > 0 && strArr[currentRow][currentCol - 1] == '0' && !visited[currentRow, currentCol - 1])
            {
                queue.Enqueue(new Tuple<int, int>(currentRow, currentCol - 1));
                visited[currentRow, currentCol - 1] = true;
            }
            if (currentCol < numCols - 1 && strArr[currentRow][currentCol + 1] == '0' && !visited[currentRow, currentCol + 1])
            {
                queue.Enqueue(new Tuple<int, int>(currentRow, currentCol + 1));
                visited[currentRow, currentCol + 1] = true;
            }
        }
    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(BitmapHoles(new string[] {"10001"}));
    }

}
