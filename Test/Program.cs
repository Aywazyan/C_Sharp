// See https://aka.ms/new-console-template for more information
int randomNumber = Random.Shared.Next(1, 100);

int guess = 0;

int minNum = 1;
int maxNum = 99;

while (guess != randomNumber)
{
    for (var i = minNum; i <= maxNum; i++)
    {
        System.Console.Write($"{i} ");
    }
    guess = int.Parse(Console.ReadLine());
    if (guess < randomNumber)
    {
        System.Console.WriteLine($"{guess} < than random number");
        minNum = guess + 1;
    }
    else if (guess > randomNumber)
    {
        System.Console.WriteLine($"{guess} > than random number");
        maxNum = guess - 1;
    }
    else
    {
        System.Console.WriteLine($"Random number was {guess}");
    }
}

// 1 2 3 4 5 6 7 8 9
// 7 pahac
