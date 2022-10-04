/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] getRandomArray(int length, int startPoint, int endPoint)
{
    double[] resultArray = new double[length];
    Random rand = new Random();
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rand.Next(startPoint, endPoint) + rand.NextDouble();
    }
    return resultArray;
}
void printArray(double[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if(i < incomingArray.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine("]");
}
double deductibleDifferenceOfMaxAndMinInArray(double[] incomingArray)
{
    double deductibleDifference = 0;
    double max = incomingArray[0];
    double min = incomingArray[0];
    for (int i = 0; i < incomingArray.Length - 1; i++)
    {
        if (incomingArray[i] > max) max = incomingArray[i]; 
        if (incomingArray[i] < min) min = incomingArray[i];
    }
    deductibleDifference = max - min;
    return deductibleDifference;
}

double[] currentArray = getRandomArray(5, 1, 100);
printArray(currentArray);
double result = deductibleDifferenceOfMaxAndMinInArray(currentArray);
Console.WriteLine(result);
