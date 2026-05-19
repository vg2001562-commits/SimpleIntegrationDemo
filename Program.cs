@'
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ICalculator calculator = new OrderCalculator();
        ResultPrinter printer = new ResultPrinter();

        // Тест 1: сумма < 1000
        List<decimal> test1 = new List<decimal> { 200, 300 };
        decimal total1 = calculator.CalculateTotal(test1);
        printer.PrintResult(total1);

        // Тест 2: сумма > 1000
        List<decimal> test2 = new List<decimal> { 500, 600, 200 };
        decimal total2 = calculator.CalculateTotal(test2);
        printer.PrintResult(total2);

        // Тест 3: пустой заказ
        List<decimal> test3 = new List<decimal>();
        decimal total3 = calculator.CalculateTotal(test3);
        printer.PrintResult(total3);
    }
}
'@ | Out-File -Encoding utf8 Program.cs
