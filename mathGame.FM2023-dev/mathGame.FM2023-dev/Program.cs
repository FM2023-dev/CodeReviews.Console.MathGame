
using System;


namespace mathGame.FM2023_dev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    abstract class Question
    {
        public int answer { get; private set; }

        public int first { get; private set; }
        public int second { get; private set; }

        public char op { get; private set; }


        abstract public (int, int) GenerateDigits();


        string Ask() => $"{first} {op} {second} = ?";


    }
}
