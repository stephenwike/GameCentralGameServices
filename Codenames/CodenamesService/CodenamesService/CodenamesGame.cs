using System;
using System.Linq;

namespace CodenamesService
{
    public class CodenamesGame
    {
        public CardCollection Cards { get; set; }
        public TeamLayoutTile Tile { get; set; }
        public CodenamesConfiguration Config { get; set; }

        public CodenamesGame()
        {
            Config = new CodenamesConfiguration();
        }

        public void SetConfig(CodenamesConfiguration config)
        {
            Config = config;
        }

        public void Initialize()
        {
            // Shuffle and pull random tiles and generate team layout tiles
            switch (Config[0].Selected)
            {
                case 0: // CodenamesVersion.Original:
                    {
                        Cards = new CardCollection(Utility.Shuffle(new Random(), CodenamesRepository.OriginalCards).Take(25).ToList());
                        Tile = new TeamLayoutTile(5, 5, CodenamesVersion.Original);
                        break;
                    }
                case 1: // CodenamesVersion.DeepUndercover:
                    {
                        Cards = new CardCollection(Utility.Shuffle(new Random(), CodenamesRepository.DeepUnderCoverCards).Take(25).ToList());
                        Tile = new TeamLayoutTile(5, 5, CodenamesVersion.DeepUndercover);
                        break;
                    }
                case 2: // CodenamesVersion.Pictures:
                    {
                        // TODO: Implement this
                        break;
                    }
            }
        }
    }
}