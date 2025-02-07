int Sum(List<int> num , int i = 0 , int sum=0)
{
    if (num.Count==i)
    {
        return sum;
    }

    sum+=num[i];
    return Sum(num,i+1,sum);

}

System.Console.WriteLine(Sum(new List<int>{1,2,5,6,7}));
