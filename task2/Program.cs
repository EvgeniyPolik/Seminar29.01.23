int[,] GetArray(int[] size)
{
    int[,] result =  new int[size[0],size[1]];
    for (var i = 0; i < size[0]; i++)
        for (var j = 0; j < size[1]; j++)
            result[i, j] = i + j;
    return result;
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
Console.WriteLine("Введите m и n через пробел: ");
var sizeMatrix = (Console.ReadLine() ?? "").Split().Select(int.Parse).ToArray();
var expArray = GetArray(sizeMatrix);
PrintArray(expArray);
