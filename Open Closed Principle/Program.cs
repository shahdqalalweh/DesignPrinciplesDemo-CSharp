using Open_Closed_Principle.After_OCP;
using Open_Closed_Principle.Before_OCP;
using System;
using System.Diagnostics.Metrics;

namespace Open_Closed_Principle {

    internal class Program
    {
        static void Main(string[] args)
        {

            var quiz = new After_OCP.Quiz(After_OCP.QuestionBank.Generate());

            quiz.Print();

            Console.ReadKey();
        }
    }
}