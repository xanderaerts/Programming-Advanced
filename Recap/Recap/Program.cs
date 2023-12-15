﻿using System;
namespace Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> list = new List<Item>();
            
            list.Add(new Item(10, 1));
            list.Add(new Item(5, 2));
            list.Add(new Item(40, 8));
            list.Add(new Item(45, 10));


            Knapsack sack = new Knapsack(list, 10);

            Console.WriteLine(sack);

            sack.Items.Sort();
            Console.WriteLine(sack);

        }
    }
}
