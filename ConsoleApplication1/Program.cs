﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = new { name = "chols", company = "sep" };
            Console.WriteLine(nm.name + ":" + nm.company);
        }
    }
}
