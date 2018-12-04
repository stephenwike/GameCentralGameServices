using System;
using System.Linq;

namespace CodenamesService
{
    internal class CodenamesGame
    {
        internal CardCollection Cards { get; set; }
        internal TeamLayoutTile Tile { get; set; }

        internal void Initialize()
        {
            // Shuffle and pull random tiles and generate team layout tiles
            switch (CodenamesConfig.Version)
            {
                case CodenamesVersion.Original:
                    {
                        Cards = new CardCollection(Utility.Shuffle(new Random(), CodenamesRepository.OriginalCards).Take(25).ToList());
                        Tile = new TeamLayoutTile(5, 5, CodenamesVersion.Original);
                        break;
                    }
                case CodenamesVersion.NSFW:
                    {
                        // TODO: Implement this
                        break;
                    }
                case CodenamesVersion.Pictures:
                    {
                        // TODO: Implement this
                        break;
                    }

            }
        }
    }
}