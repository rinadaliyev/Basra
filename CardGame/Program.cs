using CardGame.Controllers;
using CardGame.DataAccess;
using CardGame.Model;

public class Program
{
    private static void Main(string[] args)
    {
        List<Card> cards = new List<Card>();
        List<Card> tableDeck = new List<Card>();

        CardAccess cardAccess = new CardAccess();
        CardController cardController = new CardController();

        Player player = new Player();
        Player ai = new Player();

        player.Id = 1;
        Console.WriteLine("Please enter your nickname:");
        string? name = Console.ReadLine();
        player.Name = name;
        player.Score = 0;
        player.Deck = new List<Card>();

        ai.Id = 2;
        ai.Name = "Shebo";
        ai.Score = 0;
        ai.Deck = new List<Card>();

        cards = cardAccess.GetCards();

        cardController.MixCards(cards, player, ai, tableDeck);

        Card lastCard = tableDeck[tableDeck.Count - 1];

        switch (lastCard.Value)
        {
            case 11:
                Console.WriteLine("");

                break;
            default:
                break;
        }

        Console.WriteLine(lastCard.Value + " " +lastCard.SymbolType);


    }

}