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

// void SelectionSort(int[] arr)
// {
//     int min = arr[1];

//     for (int i = 0; i < arr.Length; i++)
//     {
//         for (int j = i + 1; j < arr.Length; j++)
//         {
//             if (arr[j] < min)
//             {
//                 min = arr[j];
//             }
//         }
//         min = arr[j];
//         int temp = arr[i];
//         arr[i] = min;
//     }

//     Console.WriteLine();
// }


void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }

        int temp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temp;
    }

    Console.WriteLine();
}



int[] arr = new int[10];

FillArray(arr);
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);