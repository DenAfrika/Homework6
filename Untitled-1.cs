//Чернышев Денис
﻿using System;

namespace Seminar
{

    delegate double DoOperation(double x, double y);

    internal class Sample02
    {
        public static void Process(DoOperation doOperation, double a, double x)
        {
            double res = doOperation(a, x);
            Console.Write($" = {res}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
			
            Process(delegate (double x, double a)
            	{
                	return a * x * x;
            	}, 15, 2);
			Process(delegate (double x, double a)
					{
						return a * Math.Sin(x);
					}, 15, 2);
			
            Console.ReadLine();
        }
    }
}
