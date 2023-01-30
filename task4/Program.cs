int[,] GetArray(int n)
{
    var rnd = new  Random();
    int[,] result =  new int[n, n];
    for (var i = 0; i < n; i++)
        for (var j = 0; j < n; j++)
            result[i, j] = rnd.Next(100);
    return result;
}

int GetSumMainDiagonal(int[,] expArray)
{
    var sum = 0;
    var n = expArray.GetLength(0);
    for (var i = 0; i < n; i++)
        sum += expArray[i, i];
    return sum;
}

void PrintArray(int[,] expArray)
{
    for (int i = 0; i < expArray.GetLength(0); i++)
    {
        for (int j = 0; j < expArray.GetLength(1); j++)
        {
            Console.Write(expArray[i, j]);
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите n: ");
var sizeMatrix = int.Parse(Console.ReadLine() ?? "");
var expArray = GetArray(sizeMatrix);
Console.WriteLine("Сформированный массив: ");
PrintArray(expArray);
Console.WriteLine($"Сумма главной диаганали {GetSumMainDiagonal(expArray)}");
