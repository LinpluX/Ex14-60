Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int Chet(int num)
{
    if (num % 7 % 23 == 0)
    {
        Console.WriteLine("Ваше число кратно заданным делителям так как остаток :");
        return num % 7 % 23;
    }
    else
    {
        
        Console.WriteLine("Ваше число не кратно заданным делителям так как остаток:");
        return num % 7 % 23;
    }
}
Console.WriteLine(Chet(a));