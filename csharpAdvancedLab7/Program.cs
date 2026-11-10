#region part 1

#region 1
static void exchange<t>(ref t a, ref t b)
{
    t temp = a;
    a = b;
    b = temp;
}

decimal dec1 = 10.5m;
decimal dec2 = 20.8m;
exchange(ref dec1, ref dec2);
Console.WriteLine($"exchanged: {dec1}, {dec2}");

string str1 = "hello";
string str2 = "world";
exchange(ref str1, ref str2);
Console.WriteLine($"exchanged: {str1}, {str2}");
#endregion

#endregion
