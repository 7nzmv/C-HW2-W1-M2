int Count(int a)
{
    if (a == 0)
    return 0;

    return 1 + Count(a / 10);
}

int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Count(a));