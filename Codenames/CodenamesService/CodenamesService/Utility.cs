using Newtonsoft.Json;
using System;
using System.IO;

namespace CodenamesService
{
    internal class Utility
    {
        internal static CardCollection Shuffle(Random rand, CardCollection list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                CodenameCard value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }

        internal static CardCollection ReadJsonFile(string filename)
        {
            CardCollection cards = new CardCollection();
            string[] strings;
            using (StreamReader reader = new StreamReader(Path.Combine("JsonFiles", filename)))
            {
                string data = reader.ReadToEnd();
                strings = JsonConvert.DeserializeObject<string[]>(data);
            }

            foreach (string str in strings)
            {
                cards.Add(new CodenameCard(str));
            }
            return cards;
        }
    }
}