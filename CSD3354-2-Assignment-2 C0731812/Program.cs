﻿using System;

// Gurcharanjit Singh C0731812 // Harman Singh C0725563
// CSD3354 Section 2
// Assignment 2
// March 8,2019

namespace CSD3354_2_Assignment_2_C0731812
{
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}