//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int userNum =new int();

Console.WriteLine("Введите число  ");
userNum = Convert.ToInt32(Console.ReadLine());

int i =2;

while(i<=userNum)
{
Console.Write($"{i}, ");
i+=2;
}
