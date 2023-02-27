using System;

class MainClass
{

    public static string SymmetricMatrix(string[] strArr)
    {

        // Extrair números inteiros da string de entrada
        int[] values = new int[strArr.Length];
        int index = 0;
        foreach (string s in strArr)
        {
            if (s == "<>") continue;
            values[index++] = int.Parse(s);
        }

        // Calcular o número de linhas na matriz
        int numRows = 0;
        foreach (string s in strArr)
        {
            if (s == "<>") numRows++;
        }
        numRows++;

        // Criar matriz a partir da matriz de valores
        int numCols = values.Length / numRows;
        int[,] matrix = new int[numRows, numCols];
        index = 0;
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                matrix[i, j] = values[index++];
            }
        }

        // Matriz de transposição/troca
        int[,] transposedMatrix = new int[numCols, numRows];
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        // Checa se a matriz é simetrica
        bool isSymmetric = true;
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                if (matrix[i, j] != transposedMatrix[i, j])
                {
                    isSymmetric = false;
                    break;
                }
            }
            if (!isSymmetric) break;
        }

        // retorna o resultado
        if (numRows != numCols)
        {
            return "not possible";
        }
        else if (isSymmetric)
        {
            return "symmetric";
        }
        else
        {
            return "not symmetric";
        }

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(SymmetricMatrix(new string[] { "5", "0", "<>", "0", "5" }));
    }

}
