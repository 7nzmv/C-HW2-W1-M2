int Sum(int a)
{

    if (a == 0)
    return 0;

    return a % 10 + Sum(a / 10);
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(a));

