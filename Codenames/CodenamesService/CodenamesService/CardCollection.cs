using System.Collections.Generic;

namespace CodenamesService
{
    public class CardCollection : List<CodenameCard>
    {
        public CardCollection() { }
        public CardCollection(IEnumerable<CodenameCard> collection) : base(collection)
        {
        }
    }
}