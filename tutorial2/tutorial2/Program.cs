static double average(int[] arr)
{
    double result = 0.0;
    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[i];
    }

    result /= arr.Length;
    return result;
}

int[] temp = {1,2,3,4,5,6,7,8,9};
double result = average(temp);
Console.WriteLine(result);