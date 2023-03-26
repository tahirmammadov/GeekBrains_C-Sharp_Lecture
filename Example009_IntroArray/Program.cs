Console.Clear();

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int[] array = {11,211,31,41,15,61,17,18,19};

int Max (int[] array){
    int i = 0;
    int max = array[0];
    while (i<array.Length){
        if (array[i]>max) max = array[i];
        i++;
    } return max;}

int[] massiv = {11,21,31,41,15,61,17,18,19};

Console.WriteLine(Max(massiv));