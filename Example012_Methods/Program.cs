Console.Clear();
Console.WriteLine();

void MultiplicationTable(int length1, int length2)
{
    int result = 0;

    for (int i = 2; i < length1; i++)
    {
           for (int j = 2; j < length2; j++)
        {
            Console.SetCursorPosition((i-2)*15, (j-2)+1);
            Console.WriteLine($"{i} x {j} = {i * j}");
        }
        Console.WriteLine();
    }
}

MultiplicationTable(10, 11);
