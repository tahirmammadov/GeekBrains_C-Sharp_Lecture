Console.Clear();

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 11);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arr, bool maxType)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {

        int sortIndex = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (maxType)
            {
                if (arr[j] > arr[sortIndex]) sortIndex = j;
            }
            else
            {
                if (arr[j] < arr[sortIndex]) sortIndex = j;
            }
        }
        int temp = arr[i];
        arr[i] = arr[sortIndex];
        arr[sortIndex] = temp;
    }

    Console.WriteLine();
}

int[] arr = new int[10];

FillArray(arr);
PrintArray(arr);
SelectionSort(arr, false);
PrintArray(arr);