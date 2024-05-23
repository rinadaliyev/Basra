using CardGame.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.DataAccess
{
    public class CardAccess
    {
        List<Card> cards = new List<Card>();

        public List<Card> GetCards()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\aliye\OneDrive\Belgeler\Code\C#\CardGame\CardGame\DataAccess\Cards.json"))
            {
                string json = reader.ReadToEnd();
                cards = JsonConvert.DeserializeObject<List<Card>>(json);
            }

            return cards;

        }
    }
}
