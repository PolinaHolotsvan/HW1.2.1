double N;
bool converted = false;

Console.WriteLine("Введiть число");
do
{
    string line = Console.ReadLine();
    if (line == "")
    {
        Console.WriteLine("Ви не ввели число, введiть знову!");
    }
    else
    {
        try
        {
            N = double.Parse(line);
            Console.WriteLine($"Ви ввели число {N}");
            converted = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ви неправильно ввели число, введiть знову!");
        }
    }
}
while (!converted);

Console.ReadKey();