using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson3Code
    {
        //        Modify your old functions to fit the specification:
        //1)  Invalid height or weight or age that are not numbers should return -1 and print error message ""X" is not a valid number." where X is input from console.
        //2) Empty string for height or weight or age returns 0
        //3) Empty string for name returns "-" and print error message "Name cannot be empty." in a new line.
        //4) During BMI calculation, height or weight less or equal to 0 should print error message in console:
        //  - It should start with "Failed calculating BMI. Reason:" followed by a new line:
        //    - "Height cannot be less than zero, but was X.", where X is the console input. (X <= 0)
        //    - "Weight cannot be equal or less than zero, but was X.", where X is the console input(X <= 0)
        //    - If both height and weight are invalid, both validation messages should be printed to console(each in new line)

        public static float CalculateBMI(float weight, float height)
        {
            var heightMeter = height;
            var heightSquared = heightMeter * heightMeter;
            var bmi = weight / heightSquared;

            var Isweight = true;
            var IsHeight = true;

            if (Isweight || IsHeight == false)
            {
                Console.WriteLine("Failed calculating Bmi. Reason:");
            }
            if (weight <= 0)
            {
                //Console.WriteLine("Failed calculating Bmi. Reason:");

                Isweight = false;

                // Console.WriteLine(Environment.NewLine + "Weight cannot be less than zero, but was " + (bmi.ToString()));
                return -1;
            }
            if (height <= 0)
            {
                //Console.WriteLine("Failed calculating Bmi. Reason:");

                IsHeight = false;
                // Console.WriteLine(Environment.NewLine + "Height cannot be less than zero,but was " + (bmi.ToString()));
                return -1;
            }

            return bmi;
        }

        public static float ParseBmi(string prompt)
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();
            var IsFloat = float.TryParse(input, out var number);
            var Float = true;
            if (Float == false)
            {
                Console.WriteLine(number.ToString() + "is not a valid number.");
            }
            if (!IsFloat)
            {
                Float = false;

                return -1;
            }

            return number;
        }

        private static bool ValidateFloat(bool statement)
        {
            var input = Console.ReadLine();
            Console.WriteLine(input + " is not a valid number.");
            return false;
        }

        public static int ParseAge(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            var isNumber = int.TryParse(input, out var age);

            if (!isNumber) return -1;

            if (string.IsNullOrEmpty(input)) return 0;

            return age;
        }

        public static string ReadString(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            ValidateName(input);
            if (true)
            {
                Console.WriteLine("-" + Environment.NewLine + "Name cannot be empty.");
            }

            return input;
        }

        private static bool ValidateName(string input)
        {
            return string.IsNullOrEmpty(input);
        }
    }
}