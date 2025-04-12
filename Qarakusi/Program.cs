string symbol = "*";
string space = "";
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(space + symbol);
    space += " ";
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(symbol + space);
    space += " ";
}