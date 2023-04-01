namespace ObjectOrientedPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Object Oriented Programs");
            DeckOfCards deckOfCards = new DeckOfCards();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter your choice \n1.Deck of Cards \n2.Exit");
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
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}