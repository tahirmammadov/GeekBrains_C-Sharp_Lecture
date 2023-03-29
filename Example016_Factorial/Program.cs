Console.Clear();

double Factorial(int num)
{
    if (num == 0 || num == 1) return 1;
    else return num * Factorial (num - 1);
}

Console.WriteLine(Factorial(40));


for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}