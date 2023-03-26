Console.Clear();

void FillArrayRandom(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 10);
    }
}

void FillArrayConstant(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + " ");
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

int MaxInArray(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int[] array = new int[10];

FillArrayRandom(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

Console.WriteLine("index: " + IndexOf(array, 4));

Console.WriteLine("max: " + MaxInArray(array));
