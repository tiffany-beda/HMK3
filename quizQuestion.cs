using System;

class Program
{
    // 1) Find the Smallest and Biggest Numbers
    int[] FindMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        
        foreach (int num in numbers)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }
        return new int[] { min, max };
    }

    // 2) Sum of Absolute Values
    int getAbsSum(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            if (num < 0)
                sum += -num;
            else
                sum += num;
        }
        return sum;
    }

    // 3) Multiply by Length
    int[] MultiplyByLength(int[] numbers)
    {
        int length = numbers.Length;
        int[] result = new int[length];
        
        for (int i = 0; i < length; i++)
        {
            result[i] = numbers[i] * length;
        }
        return result;
    }

    // 4) Return the Smaller Number (Without converting to integers)
    string smallerNum(string num1, string num2)
    {
        int length1 = num1.Length;
        int length2 = num2.Length;

        if (length1 < length2)
            return num1;
        else if (length2 < length1)
            return num2;
        else
        {
            for (int i = 0; i < length1; i++)
            {
                if (num1[i] < num2[i])
                    return num1;
                else if (num2[i] < num1[i])
                    return num2;
            }
        }
        return num1;
    }

    // 5) Count 'D' in a Sentence (Case-Insensitive)
    int CountDs(string sentence)
    {
        int count = 0;
        foreach (char c in sentence)
        {
            if (c == 'd' || c == 'D')
                count++;
        }
        return count;
    }
}
