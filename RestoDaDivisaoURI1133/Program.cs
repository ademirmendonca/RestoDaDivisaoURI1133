﻿using System;

namespace RestoDaDivisaoURI1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
                        
            int menor = x;
            int maior = y;

            if (x > y)
            {
                menor = y;
                maior = x;
            }

            
            for (int i = menor+1; i < maior; i++)
            {                
                if (i % 5==2 || i % 5==3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
