double[] myArr = new double[4];
double sum = 0;

Console.WriteLine("Enter the four numbers.>>> ");

//for loop needed for input to myArray
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Number {i + 1}");
    myArr[i] = Convert.ToDouble(Console.ReadLine());
}

//output for the array
Console.Write("[");
for (int i = 0; i < 4; i++)
{
    Console.Write(myArr[i] + ", ");
}
Console.Write("]");


Console.WriteLine();

//method with return type so it can return 2 values instead of 1: the sum and the average
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
//had to set a separate variable becuase it was doubling the second call in the second writeline
double[] result = SumArr(myArr);
Console.WriteLine($"The sum is {result[0]}");
Console.WriteLine($"The average is {result[1]}");


