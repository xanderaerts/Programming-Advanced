﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Assignment assignment = new Assignment();

            string raw = Console.ReadLine();

            try
            {
               int number = Int32.Parse(raw);
               Console.WriteLine(assignment.NthCharacter(number,"words.txt")); 
            }
            catch 
            {
                Console.WriteLine("Crazy input!");
            }

        }
    }
}