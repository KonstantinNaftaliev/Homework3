// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Напишите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4])
    {
        if (number[1] == number[3])
        {
            Console.WriteLine($"Ваше число: {number} - палиндром.");
        }
        else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine("Ваше число не отвечает требованиям задачи");
