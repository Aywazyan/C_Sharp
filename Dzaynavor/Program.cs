string dzaynavor = "aoieu";

string text = "Barev";
string changedText = "";

for (int i = 0; i < text.Length; i++)
{
    // bool isDzaynavor = false;
    // for (int j = 0; j < dzaynavor.Length; j++)
    // {
    //     if (text[i] == dzaynavor[j])
    //     {
    //         isDzaynavor = true;
    //         break;
    //     }
    // }
    if (dzaynavor.IndexOf(text[i]) != -1)
    {
        changedText += dzaynavor[Random.Shared.Next(0, dzaynavor.Length)];
    }
    else
    {
        changedText += text[i];
    }
}

System.Console.WriteLine(changedText);