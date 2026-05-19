@'
using System.Collections.Generic;

public interface ICalculator
{
    decimal CalculateTotal(List<decimal> prices);
}
'@ | Out-File -Encoding utf8 ICalculator.cs
