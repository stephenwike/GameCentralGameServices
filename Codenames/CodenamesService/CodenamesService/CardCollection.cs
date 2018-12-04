using System.Collections.Generic;

namespace CodenamesService
{
    internal class CardCollection : List<CodenameCard>
    {
        public CardCollection() { }
        public CardCollection(IEnumerable<CodenameCard> collection) : base(collection)
        {
        }
    }
}