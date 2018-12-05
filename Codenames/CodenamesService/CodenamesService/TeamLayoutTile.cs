using System;
using System.Linq;

namespace CodenamesService
{
    public class TeamLayoutTile
    {
        private Team StartingTeam { get; set; }
        private Team OpposingTeam { get; set; }
        private Team[] Teams { get; set; }
        private TileDetail[][] Tile { get; set; }

        internal TeamLayoutTile(int rows, int columns, CodenamesVersion version)
        {
            var rnd = new Random();

            // Create Teams
            Teams = new Team[] { new Team(TeamColor.Red), new Team(TeamColor.Blue) };
            var teamOrder = Teams.OrderBy(x => rnd.Next()).ToArray();
            StartingTeam = teamOrder[0];
            OpposingTeam = teamOrder[1];

            // Initialize Tile
            Tile = new TileDetail[rows][];
            for (int i = 0; i < rows; ++i)
            {
                Tile[i] = new TileDetail[columns];
            }

            int cardCount = rows * columns;

            // Determine version specific parameters
            int startTeam = 0;
            int challengingTeam = 0;
            int instantLose = 1;

            switch (version)
            {
                case CodenamesVersion.Original:
                case CodenamesVersion.DeepUndercover:
                    {
                        startTeam = 9;
                        challengingTeam = 8;
                        break;
                    }
                case CodenamesVersion.Pictures:
                    {
                        startTeam = 6;
                        challengingTeam = 5;
                        break;
                    }
            }

            // Determine which row and column pairs represent player tiles and instant lose tile
            int cardsToTake = startTeam + challengingTeam + instantLose;
            int[] randomNumbers = Enumerable.Range(1, cardCount).OrderBy(x => rnd.Next()).Take(cardsToTake).ToArray();

            // Initialize all TileDetails to neutral white
            int row = 0, column = 0;
            for (int i = 0; i < cardCount; ++i)
            {
                row = i / rows;
                column = i % columns;

                Tile[row][column] = new TileDetail();
            }

            // Determine start team tiles
            for (int i = 0; i < startTeam; ++i)
            {
                row = (randomNumbers[i] - 1) / rows;
                column = (randomNumbers[i] - 1) % columns;

                Tile[row][column].Color = StartingTeam.Color;
            }

            // Determine opposing team tiles
            for (int i = 0; i < challengingTeam; ++i)
            {
                row = (randomNumbers[i + startTeam] - 1) / rows;
                column = (randomNumbers[i + startTeam] - 1) % columns;

                Tile[row][column].Color = OpposingTeam.Color;
            }

            // Determine instant lose tile
            row = (randomNumbers[cardsToTake - 1] - 1) / rows;
            column = (randomNumbers[cardsToTake - 1] - 1) % columns;

            Tile[row][column].Color = TeamColor.Black;
        }
    }
}