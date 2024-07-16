// See https://aka.ms/new-console-template for more information
for (int t = 0; t < 3; t++)
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int sum = 0;
    if (num1 < num2 && num1 > 0 && num2 > 0)
    {
        for (int i = num1; i <= num2; i++)
        {
            sum += i;
            Console.Write(i + " ");

        }
        Console.Write("sum = {0} ", sum);
    }
    else if (num1 > num2 && num1 > 0 && num2 > 0)
    {
        for (int i = num2; i <= num1; i++)
        {
            sum += i;
            Console.Write(i + " ");

        }
        Console.Write("sum = {0} ", sum);
    }
    else if (num1 <= 0)
    {
        break;
    }
    else if (num2 <= 0)
    {
        break;
    }
    Console.WriteLine(" ");
}
Console.ReadLine();

