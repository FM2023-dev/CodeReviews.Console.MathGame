
using System;
using System.Collections;


namespace mathGame.FM2023_dev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question sub = new Question('-');
            Question div = new Question('/');
            Console.WriteLine(sub.ask());
            Console.WriteLine(sub.Answer);
            Console.WriteLine(div.ask());Console.WriteLine(div.Answer);
            // Console.WriteLine($"{question1.First},{question2.Second}");
            // Console.WriteLine($"{question1.First/question2.Second}");
            // Console.WriteLine($"{question2.First},{question2.Second}");

        }
    }


    public class Question
    {
        public int Answer { get; protected set; }

        public int First { get; protected set; }
        public int Second { get; protected set; }

        public char op {get; protected set;}

        public bool isDivision {get; private set;} = false;

        public string toAsk {get; private set;} = "";
        protected Random rand = new Random();

        public Question(char op)
        {
            this.op = op;
            if (op == '/')
            {
                isDivision = true;
            }
            GenerateDigits();
        }

        private int SecondGen(int first)
        {
            int snd = 0;
            while (true)
            {
                int i = rand.Next();
                if ( (i != 0) && (first % i == 0))
                {
                    snd = i;
                    break;

                }
            }
            return snd;
            
        }


         protected void GenerateDigits()
        {
            if (isDivision)
            {
                int first = rand.Next(0,101);
                int second = SecondGen(first);
                this.First = first;
                this.Second = second;
                this.Answer = first/second;
            }
            else
            {
                int first = rand.Next();
                int second = rand.Next();
                this.First = first;
                this.Second = second;
                switch (op)
                {
                    case '+':
                        this.Answer = first + second;
                        break;
                    case '-':
                        this.Answer = first - second;
                        break;
                    case '*':
                        this.Answer = first * second;
                        break;
                }
   
            }


        }


        public string ask() => $"{First} {op} {Second} = ?";
        


    }
}
