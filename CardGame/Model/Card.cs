using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Model
{
    public class Card
    {
        public int Id { get; set; }
        public int SymbolId { get; set; }
        public string? SymbolType { get; set; }
        public int Value { get; set; }
    }
}
