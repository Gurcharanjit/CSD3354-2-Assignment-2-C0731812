using System;

// Gurcharanjit Singh C0731812 // Harman Singh C0725563
// CSD3354 Section 2
// Assignment 2
// March 8,2019

namespace CSD3354_2_Assignment_2_C0731812
{
    public class Program
    {
        public delegate void MyDelegate();

        public void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate mydelegate = new MyDelegate(Method1);
            mydelegate();
        }
        static void Main(string[] args)
        {

        }
    }
}
