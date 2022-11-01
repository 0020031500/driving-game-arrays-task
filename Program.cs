string name;
string laptime;
string[] laptimes = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.Clear();
    Console.WriteLine("Enter your name: ");
    name = Console.ReadLine();
    Console.WriteLine("Enter your lap time: ");
    laptime = Console.ReadLine();

    laptimes[i] = name + " - " + laptime;
}

Console.Clear();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(laptimes[i]);
}
