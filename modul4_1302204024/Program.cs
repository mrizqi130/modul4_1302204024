﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan<double> n = new Penjumlahan<double>();
            Console.WriteLine(n.JumlahTigaAngka(1.3D, 0.2D, 2.0D));
        }
    }

    public class Penjumlahan<T>
    {   
        public T JumlahTigaAngka(T a, T b, T c)
        {
            dynamic d, var_a, var_b, var_c;
            var_a = a;
            var_b = b;
            var_c = c;
            return d= var_a + var_b + var_c;
            //Console.WriteLine(var_a+var_b+var_c);

        }
    }
}
