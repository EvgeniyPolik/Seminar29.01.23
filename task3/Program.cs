int[,] GetRandomArray(int[] size)
{
    var rnd = new  Random();
    int[,] result =  new int[size[0],size[1]];
    for (var i = 0; i < size[0]; i++)
        for (var j = 0; j < size[1]; j++)
            result[i, j] = rnd.Next(100);
    return result;
}

void ModifyArray(int[,] originArray)
{
    
    for (var i = 0; i < originArray.GetLength(0); i+=2)
        for (var j = 0; j < originArray.GetLength(1); j+=2)
            {
                originArray[i, j] *= originArray[i, j];
            }
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
var expArray = GetRandomArray(sizeMatrix);
Console.WriteLine("Исходный массив:");
PrintArray(expArray);
ModifyArray(expArray);
Console.WriteLine("Исходный массив:");
PrintArray(expArray);
