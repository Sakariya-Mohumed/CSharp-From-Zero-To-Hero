using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Lesson3Code.ReadString("Enter your first name:  ");
            Lesson3Code.ReadString("Enter your Last name: ");

            Lesson3Code.ParseAge("Enter your age: ");

            Lesson3Code.CalculateBMI(Lesson3Code.ParseBmi("Enter weight: "), Lesson3Code.ParseBmi("Enter height: "));
        }
    }
}