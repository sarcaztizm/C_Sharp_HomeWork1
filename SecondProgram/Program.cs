Console.WriteLine ("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите третье число");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber > SecondNumber)
{
    if (FirstNumber > SecondNumber)
        Console.WriteLine ("Max = " + FirstNumber);
}
else
{
    if (SecondNumber > ThirdNumber)
        Console.WriteLine ("Max = " + SecondNumber);
    else
        Console.WriteLine ("Max = " + ThirdNumber);
}
