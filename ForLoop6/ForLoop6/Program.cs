﻿using System;
class ProdSum
{
    static void Main()
    {
        int prod;
        int sum;
        int i;
        sum = 0;
        prod = 1;
        for (i = 1; i <= 10; i++)
        {
            sum = sum + i;
            prod = prod * i;
        }
        Console.WriteLine("Sum is " + sum);
        Console.WriteLine("Product is " + prod);
    }
}

//The output is shown here:
//Sum is 55
//Product is 3628800
//Почему вывод такой большой откуда взялись такие большие числа
