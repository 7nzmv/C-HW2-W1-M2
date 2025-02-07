bool Prime(int a, int i = 2)
{
    if (a <= 1)
    return false;

    if (i * i > a)
    return true;

    if (a % i == 0)
    return false;

    return Prime(a, i + 1);
}

int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Prime(a));

