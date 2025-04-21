double[] myArr = new double[4];
double sum = 0;

Console.WriteLine("Enter the four numbers.>>> ");

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Number {i + 1}");
    myArr[i] = Convert.ToDouble(Console.ReadLine());
}

Console.Write("[");
for (int i = 0; i < 4; i++)
{
    Console.Write(myArr[i] + ", ");
}
Console.Write("]");


Console.WriteLine();


double[] SumArr(double[] myArr)
{
    double[] sumAverage = new double[2];
    for (int i = 0; i < 4; i ++)
    {
        sum += myArr[i];
    }
    sumAverage[0] = sum;
    sumAverage[1] = sum / myArr.Length;
    return sumAverage;
}
double[] result = SumArr(myArr);
Console.WriteLine($"The sum is {result[0]}");
Console.WriteLine($"The average is {result[1]}");


