void Natural(int a = 1)
{

    if (a > 50)
    return;
    Console.Write(a + " ");

    Natural(a + 1);
}

Natural();
