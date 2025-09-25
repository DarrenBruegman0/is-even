// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.Write("input a number>  ");
    int even_or_odd = Convert.ToInt32(Console.ReadLine());
    if (even_or_odd % 2 == 0)
    {
        Console.WriteLine($"The Number {even_or_odd} is Even!");
    }
    else
    {
        Console.WriteLine($"The Number {even_or_odd} is Odd!");
    }
}