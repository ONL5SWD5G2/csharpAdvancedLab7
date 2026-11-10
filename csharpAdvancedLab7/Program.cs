#region part 1

#region 1
//static void exchange<t>(ref t a, ref t b)
//{
//    t temp = a;
//    a = b;
//    b = temp;
//}

//decimal dec1 = 10.5m;
//decimal dec2 = 20.8m;
//exchange(ref dec1, ref dec2);
//Console.WriteLine($"exchanged: {dec1}, {dec2}");

//string str1 = "hello";
//string str2 = "world";
//exchange(ref str1, ref str2);
//Console.WriteLine($"exchanged: {str1}, {str2}");
//#endregion

#region 2
class pair<tfirst, tsecond>
{
    public tfirst first { get; set; }
    public tsecond second { get; set; }

    public pair(tfirst first, tsecond second)
    {
        this.first = first;
        this.second = second;
    }

    public void print()
    {
        Console.WriteLine($"route: {first}, destination: {second}");
    }
}

pair<int, string> bus = new pair<int, string>(42, "downtown");
bus.print();
#endregion

#endregion
