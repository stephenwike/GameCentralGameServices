namespace CodenamesService
{
    public class stub
    {
        public static void Main()
        {
            CodenamesGame game = new CodenamesGame();

            // Get/Set Configuration
            CodenamesConfiguration config = game.Config;
            // Make changes to config here...
            game.SetConfig(config);

            // Initialize Gameboard
            game.Initialize();

            var cards = game.Cards;

            // Get/Set Configuration
            config[0].Selected = 1;
            // Make changes to config here...
            game.SetConfig(config);

            game.Initialize();

            cards = game.Cards;
        }
    }
}
