//Option 1 with basic syntax
int a = 10;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);

// //Option 2 with complex syntax 
// int length = 5;
// int[] array = new int[length];
// int max = 0;

// for (int i = 0; i < length; i++)
// {
//     array[i] = new Random().Next(0, 100);
//     Console.Write(array[i] + " ");

//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }

// Console.WriteLine();
// Console.WriteLine(max);

