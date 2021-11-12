//Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число больше 1 и меньше 1000");
int a = Convert.ToInt32(Console.ReadLine());
if ( a < 1 || a > 999 )
{
    Console.WriteLine("Введите число по выше предложенному диапазону");
    return;
}
int SNumber (int Num)
{
    if(Num < 100)
    {
       return Num = Num % 10;
    } 
    else
    {
        return Num = Num / 10 % 10;

    }
}
Console.WriteLine("Вторая цифра в числе равняется:");
Console.WriteLine(SNumber(a));


