﻿using System;

namespace Alphabetize
{


    public class Alpha
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static string AlphabetizedString(string inputString)
        {
            inputString = inputString.ToLower();
            string result = "";

            for (int i = 'a'; i <= 'z'; i++)
            {
                for (int j = 0; j < inputString.Length; j++)
                {
                    if (inputString[j] == i)
                    {
                        result += inputString[j];
                        break;
                    }
                }
            }
            return result;
        }
    }
}
