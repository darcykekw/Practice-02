﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            for (int i = 1; i < number; i += 2)
            { Console.WriteLine("This number is odd, " + i); }
        }
    }
}
