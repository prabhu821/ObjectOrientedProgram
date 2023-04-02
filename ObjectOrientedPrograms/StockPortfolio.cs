using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms;

public class StockPortfolio
{
    public List<Stock> stocks = new List<Stock>();

    public void AddStock(Stock stock)
    {
        stocks.Add(stock);
    }
    public decimal GetTotalValue()
    {
        decimal totalValue = 0;
        foreach (Stock stock in stocks)
        {
            totalValue += stock.GetValue();
        }
        return totalValue;
    }

    public void PrintReport()
    {
        Console.WriteLine("Stock Report");
        Console.WriteLine("============");
        foreach (Stock stock in stocks)
        {
            decimal value = stock.GetValue();
            Console.WriteLine("{0} ({1} shares) - {2}", stock.Name, stock.NumberOfShares, value);
        }
        decimal totalValue = GetTotalValue();
        Console.WriteLine("Total value of all stocks: {0}", totalValue);
    }
    public void BuyStock()
    {
        Console.WriteLine("Buy Stock");
        Console.WriteLine("=========");

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Number of shares: ");
        int numberOfShares = int.Parse(Console.ReadLine());
        Console.Write("Share price: ");
        decimal sharePrice = decimal.Parse(Console.ReadLine());

        Stock stock = new Stock
        {
            Name = name,
            NumberOfShares = numberOfShares,
            SharePrice = sharePrice
        };
        AddStock(stock);

        Console.WriteLine("{0} shares of {1} bought at {2} each.", numberOfShares, name, sharePrice);
    }
    public void SellStock()
    {
        Console.WriteLine("Sell Stock");
        Console.WriteLine("==========");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Stock stock = stocks.Find(s => s.Name == name);

        if (stock == null)
        {
            Console.WriteLine("No shares of {0} found in portfolio.", name);
            return;
        }

        Console.Write("Number of shares: ");
        int numberOfShares = int.Parse(Console.ReadLine());

        if (numberOfShares > stock.NumberOfShares)
        {
            Console.WriteLine("Not enough shares of {0} to sell.", name);
            return;
        }

        Console.Write("Share price: ");
        decimal sharePrice = decimal.Parse(Console.ReadLine());

        if (sharePrice < stock.SharePrice)
        {
            Console.WriteLine("Warning: selling at a lower price than purchased.");
        }

        stock.NumberOfShares -= numberOfShares;

        decimal saleValue = numberOfShares * sharePrice;
        decimal purchaseValue = numberOfShares * stock.SharePrice;
        decimal profit = saleValue - purchaseValue;
        Console.WriteLine("{0} shares of {1} sold at {2} each for a total of {3}.", numberOfShares, name, sharePrice, saleValue);

        if (profit > 0)
        {
            Console.WriteLine("Profit: {0}", profit);
        }
        else if (profit < 0)
        {
            Console.WriteLine("Loss: {0}", -profit);
        }
    }
}


