using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms;

public class Stock
{
    public string Name { get; set; }
    public int NumberOfShares { get; set; }
    public decimal SharePrice { get; set; }

    public decimal GetValue()
    {
        return NumberOfShares * SharePrice;
    }
}
