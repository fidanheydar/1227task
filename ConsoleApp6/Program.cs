using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine(Sum(20,30,40));
            Console.WriteLine(Sum(20.5, 30.5, 40.5));
            //Task2
            Console.WriteLine(Sum(new int[] {10,20,30}));
            Console.WriteLine(Sum(new double[] { 10.2,20.4,30.5 }));
            Console.WriteLine(FindFirstIndex("Salam",'a'));     //Task3
            Console.WriteLine(FindLastIndex("Salam", 'a'));      //Task4
            Console.WriteLine(FindTheBiggest(new int[] { 10,20,30 }));  //Task5
            Console.WriteLine(IsPosEven(25));  //Task6
            Console.WriteLine(CountPosEven(new int[] { 10,20,30,43 }));  //Task7
            Console.WriteLine(RemoveLeftSpace("  salam"));   //Task10
            Console.WriteLine(RemoveRightSpace("salam    "));   //Task11
            int[] reversedArray = ReversedArray(new int[] { 10, 20, 30, 45, 53, 67 });  //Task9
            Console.Write("Reversed array: ");
            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.Write(reversedArray[i]);
                if (i < reversedArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(  );


            int[] positiveEvenArray = PositiveNumsArray(new int[] { 10, 20, 30, 45, 53, 67 });

            Console.Write("Positive and Even array: ");
            for (int i = 0; i < positiveEvenArray.Length; i++)
            {
                Console.Write(positiveEvenArray[i]);
                if (i < positiveEvenArray.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();






        }
        #region Task1
        static int Sum(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;
            return sum;
        }

        static double Sum(double num1, double num2, double num3)
        {
            double sum = num1 + num2 + num3; return sum;
        }
        #endregion
        #region Task2
        static int Sum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        static double Sum(double[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        #endregion
        #region Task3
        static int FindFirstIndex(string text, char character)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == character)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion
        #region  Task4
        static int FindLastIndex(string text, char character)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (text[i] == character)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion
        #region Task5
        static int FindTheBiggest(int[] nums)
        {
            int theBiggest = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > theBiggest)
                {
                    theBiggest = nums[i];
                }
            }
            return theBiggest;
        }
        #endregion
        #region Task6
        static bool IsPosEven(int num)
        {
            if(num>0 && num % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }
        #endregion
        #region Task7 
        static int CountPosEven(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        #endregion
        #region  Task10
        static string RemoveLeftSpace(string str)
        {
            string newStr = "";
            int startIndex = FindFirstNonSpaceIndex(str);

            if (startIndex == -1)
                return str;

            for (int i = startIndex; i < str.Length; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }

        static int FindFirstNonSpaceIndex(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ') 
                    return i;
            }

            return -1;
        }

        #endregion
        #region  Task11
        static string RemoveRightSpace(string text)
        {

            int endIndex = text.Length - 1;
            string newText = "";
            while (endIndex >= 0 && text[endIndex] == ' ')
            {
                endIndex--;
            }
            for (int i = 0; i <= endIndex; i++)
            {
                newText += text[i];
            }
            return newText;

        }
        #endregion
        #region Task9
        static int[] ReversedArray(int[] nums)
    {
        int count = nums.Length;

        int[] newArray = new int[count];
        int index = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            newArray[index] = nums[i];
            index++;
        }
        return newArray;
            #endregion
        }
        #region Task8
        static int[] PositiveNumsArray(int[] nums)
        {
            int positiveCount = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] % 2 == 0)
                {
                    positiveCount++;
                }
            }
            int[] newArr = new int[positiveCount];
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] > 0 && nums[j] % 2 == 0)
                {
                    newArr[index] = nums[j];
                    index++;
                }
            }
            return newArr;
    #endregion
        }
       

        }

    
  



}





