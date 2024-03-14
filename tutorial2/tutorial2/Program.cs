﻿static double average(int[] arr)
{
    double result = 0.0;
    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[i];
    }

    result /= arr.Length;
    return result;
}

static int maxElement(int[] arr)
{
    int result = arr[0];
    for (int anotherNewName = 1; anotherNewName < arr.Length; anotherNewName++)
    {
        if (result < arr[anotherNewName])
        {
            result = arr[anotherNewName];
        }
    }
    return result;
}

int[] temp = {1,2,3,4,5,6,7,8,9};
double result = average(temp);
int result2 = maxElement(temp);
Console.WriteLine(result);
Console.WriteLine(result2);