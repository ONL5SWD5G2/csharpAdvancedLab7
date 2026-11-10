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
#endregion

#region 2
//class pair<tfirst, tsecond>
//{
//    public tfirst first { get; set; }
//    public tsecond second { get; set; }

//    public pair(tfirst first, tsecond second)
//    {
//        this.first = first;
//        this.second = second;
//    }

//    public void print()
//    {
//        Console.WriteLine($"route: {first}, destination: {second}");
//    }
//}

//pair<int, string> bus = new pair<int, string>(42, "downtown");
//bus.print();
#endregion

#region 3
//static int findindex<t>(t[] array, t value)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i].Equals(value))
//        {
//            return i;
//        }
//    }
//    return -1;
//}

//string[] codes = { "ex-101", "ex-102", "ex-103" };
//int idx = findindex(codes, "ex-102");
//Console.WriteLine($"index: {idx}");
#endregion

#endregion

#region part 2

#region 4
//class librarybook : IEquatable<librarybook>
//{
//    public string catalogcode { get; set; }
//    public string title { get; set; }
//    public string author { get; set; }

//    public librarybook(string catalogcode, string title, string author)
//    {
//        this.catalogcode = catalogcode;
//        this.title = title;
//        this.author = author;
//    }

//    public bool Equals(librarybook? other)
//    {
//        if (other is null) return false;
//        return catalogcode == other.catalogcode && title == other.title && author == other.author;
//    }

//    public override bool Equals(object? obj) => Equals(obj as librarybook);

//    public override int GetHashCode() => HashCode.Combine(catalogcode, title, author);
//}

//librarybook book1 = new librarybook("b1", "c#", "sam");
//librarybook book2 = new librarybook("b1", "c#", "sam");
//Console.WriteLine($"equal: {book1.Equals(book2)}");
#endregion

#region 5
//class bookcomparer : IEqualityComparer<librarybook>
//{
//    public bool Equals(librarybook? x, librarybook? y)
//    {
//        if (x is null && y is null) return true;
//        if (x is null || y is null) return false;
//        return x.catalogcode == y.catalogcode;
//    }

//    public int GetHashCode(librarybook obj) => obj.catalogcode.GetHashCode();
//}

//static int findbook<t>(t[] array, t value, IEqualityComparer<t> comparer)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (comparer.Equals(array[i], value)) return i;
//    }
//    return -1;
//}

//librarybook[] catalog = { new librarybook("lib-1", "title a", "author a") };
//librarybook search = new librarybook("lib-1", "title b", "author b");
//int found = findbook(catalog, search, new bookcomparer());
//Console.WriteLine($"found index: {found}");
#endregion

#endregion

#region part 3

#region 6
//Predicate<decimal> checktotal = total => total >= 150m;
//Console.WriteLine($"120 valid: {checktotal(120m)}");
//Console.WriteLine($"180 valid: {checktotal(180m)}");
#endregion

#region 7
//Func<string, int> getlength = label => label.Trim().Length;
//Console.WriteLine($"badge length: {getlength("  john  ")}");
//Console.WriteLine($"badge length: {getlength(" anna ")}");
#endregion

#region 8
Action<string> announce = msg => Console.WriteLine($"announcement: {msg}");
announce("train departing platform 1");
announce("train arriving platform 2");
#endregion

#endregion
