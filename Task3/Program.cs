// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int result = CalculatingCubes(a);
Console.WriteLine(result);

int CalculatingCubes(int a)
{
    for (int i = 1; i <= a; i++)
    {
        double x = Math.Pow(i, 3);
        Console.Write(x);
        Console.Write(" ");
    }
return a;
}