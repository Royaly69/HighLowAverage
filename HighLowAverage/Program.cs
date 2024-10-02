
using System.Collections.Generic;
string ans;
Console.WriteLine("Indtast på en linje af motivationsscorer, del med space");
ans = Console.ReadLine();

Console.WriteLine(HighLow(ans));
static string HighLow(string numbers)
{
    int high;
    int low;
    int i;
    int sum = 0;
    int amount = 0;
    string[] arr = numbers.Split(" ");
    high = Convert.ToInt32(arr[0]);
    low = Convert.ToInt32(arr[0]);
    foreach (string s in arr)
    {
        ++amount;
        try
        {
            i = Convert.ToInt32(s);
            sum += i;
        }
        catch
        {
            return "error";
        }
        if (i > high)
        {
            high = i;
        }
        else if (i < low)
        {
            low = i;
        }
    }

    return "Højeste: " + high + " Laveste: " + low + " Gennemsnit: " + sum / amount;
}
