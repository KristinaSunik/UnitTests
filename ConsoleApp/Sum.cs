using System;

public class Sum
{
    /// <summary>
    /// calculate the sum of two numbers in the string formatt
    /// </summary>
    /// <param name="firstNumber">a number to sum</param>
    /// <param name="secondNumber">another number to sum</param>
    /// <returns>the sum (in string formatt) of two numbers in string formatt</returns>
    public static string Calculate(string firstNumber, string secondNumber)
    {
        int iterations;
        int iterationsCount = 0;
        int leftover = 0;
        int currentNumber;

        firstNumber = firstNumber.Replace(" ", "");
        secondNumber = secondNumber.Replace(" ", "");
        if (secondNumber.Length > firstNumber.Length) //make the first number the biggest
        {
            string temp = secondNumber;
            secondNumber = firstNumber;
            firstNumber = temp;
        }

        int firstLength = firstNumber.Length;
        int secondLength = secondNumber.Length;
        if (firstLength >= 6)
        {
            iterations = secondNumber.Length;    // count how many operations we need 
            int j = secondLength - 1;
            bool flag = false;
            
            for (int i = firstLength - 1; i >= 0; i--)
            {
                iterationsCount++;
                currentNumber = Convert.ToInt32(firstNumber[i].ToString()) + Convert.ToInt32(secondNumber[j].ToString()) + leftover;
                var pair = CheckQuantityOfDigits(firstNumber, currentNumber, i);
                leftover = pair.Item2;
                firstNumber = pair.Item1;

                if (iterationsCount == iterations)
                {
                    while (i >= 0)
                    {
                        //if it is the last operation of summing and we have a leftover
                        if (leftover != 0 && i > 0)
                        {
                            currentNumber = Convert.ToInt32(firstNumber[i - 1].ToString()) + leftover;
                            pair = CheckQuantityOfDigits(firstNumber, currentNumber, i - 1);
                            firstNumber = pair.Item1;
                            leftover = pair.Item2;
                                       //itterations through the bigger(first) number
                        }

                        //if we still have a leftover and the number becomes bigger than it was
                        if (iterations == firstLength)
                        {
                            if (leftover != 0)
                            {
                                firstNumber = leftover.ToString() + firstNumber;
                                flag = true;
                                break;
                            }
                        }
                        iterations++;
                        i--;
                    }
                }

                j--;           //itterations through the second number
                if (flag)
                {
                    break;
                }
            }
        }

        else
        {
            firstNumber = Convert.ToString(Convert.ToInt32(firstNumber) + Convert.ToInt32(secondNumber));
        }

        return firstNumber;
    }

    /// <summary>
    /// checks if there are a few digits - writing only the second. the other is to remember
    /// </summary>
    /// <param name="firstNumber">the number to change</param>
    /// <param name="currentNumber">the number from the current sum</param>
    /// <param name="i">current position in the number</param>
    /// <returns>summary number after summing and leftover for the next operation of sum</returns>
    public static Tuple<string, int> CheckQuantityOfDigits(string firstNumber, int currentNumber, int i)
    {
        int leftover;
        if (currentNumber >= 10)
        {
            firstNumber = firstNumber.Remove(i, 1);
            firstNumber = firstNumber.Insert(i, Convert.ToString(currentNumber % 10));
            leftover = 1;
        }
        else
        {
            firstNumber = firstNumber.Remove(i, 1);
            firstNumber = firstNumber.Insert(i, Convert.ToString(currentNumber));
            leftover = 0;
        }

        return Tuple.Create(firstNumber, leftover);
    }
}
