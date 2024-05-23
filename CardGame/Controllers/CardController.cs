using CardGame.Business;
using CardGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Controllers
{
    public class CardController
    {
        public void MixCards(List<Card> cards, Player player, Player ai, List<Card> tableDeck)
        {
            while (player.Deck.Count < 4 || ai.Deck.Count < 4 || tableDeck.Count < 4)
            {
                Random rand = new Random();
                int index = rand.Next(0, cards.Count);

                if (player.Deck.Count < 4)
                {
                    player.Deck.Add(cards[index]);
                    cards.Remove(cards[index]);
                }
                else if (ai.Deck.Count < 4)
                {
                    ai.Deck.Add(cards[index]);
                    cards.Remove(cards[index]);
                }
                else
                {
                    tableDeck.Add(cards[index]);
                    cards.Remove(cards[index]);
                }
            }
        }

        public void GiveCards(List<Card> cards, Player player, Player ai)
        {
            while (player.Deck.Count < 4 || ai.Deck.Count < 4)
            {
                Random rand = new Random();
                int index = rand.Next(0, cards.Count);

                if (player.Deck.Count < 4)
                {
                    player.Deck.Add(cards[index]);
                    cards.Remove(cards[index]);
                }
                else
                {
                    ai.Deck.Add(cards[index]);
                    cards.Remove(cards[index]);
                }

            }
        }

        public void AddCard(Player player, Card card, List<Card> tableDeck, List<Card> cards)
        {
            CardManager cardManager = new CardManager();
            if (cardManager.CheckCut(player, card, tableDeck) == true)
            {
                CutCard(player, card, tableDeck);
            }
        }

        public void CutCard(Player player,Card card, List<Card> tableDeck)
        {
            CardManager cardManager = new CardManager();

            if (cardManager.CheckBasra(player, card, tableDeck) == true)
            {
                player.Score += 10;
            }


            foreach (var item in tableDeck)
            {
                player.SideDeck.Add(item);
            }

            tableDeck.Clear();

        }
    }
}
