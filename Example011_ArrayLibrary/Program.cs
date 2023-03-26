Console.Clear();

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i]+" ");
    }
}

int IndexOf(int[] collection, int find)
{
    
    int position = -1;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] == find)
        {
            position = i;
            break;
        }
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

Console.WriteLine(IndexOf(array, 4));
