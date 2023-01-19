﻿using System;
using System.Numerics;

namespace TestAlgolithum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input A : ");
            //string a = Console.ReadLine();
            //Console.Write("Input B : ");
            //string b = Console.ReadLine();
            //BigInteger bigInt1 = BigInteger.Parse(a);
            //BigInteger bigInt2 = BigInteger.Parse(b);
            //BigInteger sum = bigInt1 + bigInt2; 
            //Console.WriteLine(sum);

            string num1 = "999999999999999999999999999999999999999";
            string num2 = "1";
            string sum = AddLargeIntegers(num1, num2);
            Console.WriteLine(sum);

        }

        public static string AddLargeIntegers(string num1, string num2)
        {
            // Initialize variables to store the result
            string result = "";
            int carry = 0;

            // Make sure the two numbers have the same number of digits
            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else if (num1.Length < num2.Length)
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }

            // Iterate through the digits of the numbers from right to left
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                // Add the digits and carry
                int digitSum = int.Parse(num1[i].ToString()) + int.Parse(num2[i].ToString()) + carry;

                // Calculate the carry for the next iteration
                carry = digitSum / 10;

                // Add the current digit to the result
                result = digitSum % 10 + result;
            }

            // Check if there is a final carry
            if (carry > 0)
            {
                result = carry + result;
            }

            return result;
        }
    }
}
