using CardGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Business
{
    public class CardManager
    {
        public bool CheckCut(Player player, Card card, List<Card> tableDeck)
        {
            int lIndex = tableDeck.Count - 1;


            if (card.Value == 11 || card.Value == tableDeck[lIndex].Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckBasra(Player player, Card card, List<Card> tableDeck)
        {
            int lIndex = tableDeck.Count - 1;

            if (card.Value == tableDeck[lIndex].Value)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
    }
}
