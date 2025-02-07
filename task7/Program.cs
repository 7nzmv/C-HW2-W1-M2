string Reverse(string a)
{
    if (a.Length == 0 || a.Length == 1)
        return a;

    char s = a[0];
    string rev = Reverse(a.Substring(1));
    return rev + s;
}

string a = Console.ReadLine();
System.Console.WriteLine(Reverse(a));
