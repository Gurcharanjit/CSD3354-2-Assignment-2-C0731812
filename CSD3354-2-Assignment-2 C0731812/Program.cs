using System;

// Gurcharanjit Singh C0731812 // Harman Singh C0725563
// CSD3354 Section 2
// Assignment 2
// March 8,2019

namespace CSD3354_2_Assignment_2_C0731812
{

    public class Program
    {
        static void Main(string[] args)
        {
            DelegateExcercises delegateExcercises = new DelegateExcercises();
            delegateExcercises.Method3();
            Console.ReadLine();
        }
    }
    public class DelegateExcercises
    {
        public delegate int MyDelegate(int intValue);

        int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }
        int Method2(int intMethod1)
        {
            return intMethod1 * 10;
        }
        public void Method4(MyDelegate myDelegate)
        {
            int result = myDelegate(10);
            Console.WriteLine(result);
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            Method4(myDelegate);
            myDelegate = new MyDelegate(Method2);
            Method4(myDelegate);
        }
    }
}