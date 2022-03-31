int count = 0;
for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine("Введите любое число:");
    int M = Convert.ToInt32(Console.ReadLine());
    if(M > 0)
    {
        count++;
    }
}
System.Console.WriteLine($"Количество положительных чисел: {count}");