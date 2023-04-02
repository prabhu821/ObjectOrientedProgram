namespace ObjectOrientedPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Object Oriented Programs");
            DeckOfCards deckOfCards = new DeckOfCards();
            StockPortfolio portfolio = new StockPortfolio();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter your choice \n1.Deck of Cards \n2.Add Stock \n3.Display Stock \n4.Buy Stock" +
                    "\n5.Sell Stock \n6.Exit");
                Console.WriteLine("Enter option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        deckOfCards.Card();
                        deckOfCards.Shuffle();
                        deckOfCards.Distribute();
                        deckOfCards.Display();
                        break;
                    case 2:
                        Console.Write("Enter the number of stocks: ");
                        int numberOfStocks = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= numberOfStocks; i++)
                        {
                            Console.WriteLine("Enter details for stock {0}:", i);
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
                            portfolio.AddStock(stock);
                        }
                        break;
                    case 3:
                        portfolio.PrintReport();
                        break;
                    case 4:
                        portfolio.BuyStock();
                        break;
                    case 5:
                        portfolio.SellStock();
                        break;  
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}