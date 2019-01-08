﻿using System;

namespace lab01_aboutme
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1
            int answerForQ1 = q1Siblings();
            Console.WriteLine($"The answer is {answerForQ1}");

            //question 2
            string answerForQ2 = q2Color();
            Console.WriteLine($"The answer is {answerForQ2}");

            //question 3
            bool answerForQ3 = q3Foodie();
            Console.WriteLine($"The answer is {answerForQ3}");


            //question 4
            int answerForQ4 = q4FavNum();
            Console.WriteLine($"The answer is {answerForQ4}");

            //question 5
            string answerForQ5 = q5Name();
            Console.WriteLine($"The answer is {answerForQ5}");
            Console.ReadLine(); // so it doesn't auto exit

        }

        //question one, asks the user for guess, determine if it is right or wrong, returns correct answer
        //add try block on this question: null? # too big? is it not a number? general exception
        private static int q1Siblings()
        {
            Console.WriteLine("How many siblings do I have?");
            string q1SiblingsGuess = Console.ReadLine();
            int q1Answer = 1;
            try
            {
                int q1SiblingsGuessInt = Convert.ToInt32(q1SiblingsGuess);
                if (q1SiblingsGuessInt != q1Answer)
                {
                    Console.WriteLine("Good guess");
                    return q1Answer;
                }
                else
                    return q1Answer;
            }
            catch (NullReferenceException) //i can't seem to get a null guess from the user
            {
                Console.WriteLine("You didn't make an entry");
                return q1Answer;
            }
            catch (Exception)
            {
                Console.WriteLine("We don't like what you entered, andt we dont have to tell you WHYYYYYY");
                return q1Answer;
            }
        }

        //question two, asks the user for guess, determine if it is right or wrong, returns correct answer
        private static string q2Color()
        {
            Console.WriteLine("What is my favorite color?");
            string q2ColorGuess = Console.ReadLine();
            string q2ColorGuessCap = q2ColorGuess.ToUpper();
            string q2Answer = "PINK";
            if (q2ColorGuessCap != q2Answer)
            {
                Console.WriteLine("Good guess");
                return q2Answer;
            }
            else
                return q2Answer;
        }

        //question three, asks the user for guess, determine if it is right or wrong, returns correct answer
        private static bool q3Foodie()
        {
            Console.WriteLine("True or false: I am a foodie");
            string q3FoodieGuess = Console.ReadLine();
            bool q3FoodieGuessBool = Convert.ToBoolean(q3FoodieGuess);
            bool q3Answer = true;
            if (q3FoodieGuessBool != q3Answer)
            {
                Console.WriteLine("Good guess");
                return q3Answer;
            }
            else
                return q3Answer;
        }

        //question four, asks the user for guess, determine if it is right or wrong, returns correct answer
        private static int q4FavNum()
        {
            Console.WriteLine("What is my favorite Number?");
            string q4FavNumGuess = Console.ReadLine();
            int q4FavNumGuessInt = Convert.ToInt32(q4FavNumGuess);
            int q4Answer = 36;
            if (q4FavNumGuessInt != q4Answer)
            {
                Console.WriteLine("Good guess");
                return q4Answer;
            } else
                return q4Answer;
        }

        //question five, asks the user for guess, determine if it is right or wrong, returns correct answer
        private static string q5Name()
        {
            Console.WriteLine("What is my current favorite name?");
            string q5NameGuess = Console.ReadLine();
            string q5NameGuessCap = q5NameGuess.ToUpper();
            string q5Answer = "JASPER";
            if (q5NameGuessCap != q5Answer)
            {
                Console.WriteLine("Good guess");
                return q5Answer;
            }
            else
                return q5Answer;
        }
    }
}
