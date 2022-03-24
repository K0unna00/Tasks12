using System;

namespace Task12
{
    internal class Program
    {
        //////Task 6 ve 7ni dersde yazmisdim ve yoxlamisdiz :)

        static void Main(string[] args)
        {

        }
        static void clearSpaces(ref string str)
        {
            string[] arr = str.Split(' ');
            str = "";
            foreach (var item in arr)
            {
                if (item != "")
                {
                    str += item + " ";
                }
            }
            Console.WriteLine(str.TrimEnd());
        }
        static bool check(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                {
                    count++;
                    break;
                }
            }
            foreach (var item in str)
            {
                if (char.IsUpper(item))
                {
                    count++;
                    break;
                }
            }
            foreach (var item in str)
            {
                if (char.IsLower(item))
                {
                    count++;
                    break;
                }
            }
            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string firstWord(string str)
        {
            string str2 = "";
            str = str.Trim();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != ' ')
                {
                    str2 += str[i];
                }
                else
                {
                    break;
                }
            }
            return str2;
        }
        static bool TwoWord(string str)
        {
            int count = 0;
            string str2 = "";
            string[] arr;
            str = str.Trim();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != ' ')
                {
                    str2 += str[i];
                }
                else if (str[i] == ' ' && str[i + 1] == ' ')
                {
                    continue;
                }
                else
                {
                    count++;
                    str2 += " ";
                }
                if (count == 2)
                {
                    break;
                }
            }
            if (count != 2)
            {
                return false;
            }
            arr = str2.Split(" ");
            return char.IsUpper(arr[0][0]) && char.IsUpper(arr[1][0]);
        }
        static void AddDigit(ref int[] arr, int num)
        {
            int[] newarr = new int[arr.Length + 1];
            int j = 0;
            foreach (var item in arr)
            {
                newarr[j++] = item;
            }
            newarr[arr.Length] = num;
            arr = newarr;
        }
    }
}
