using Configuration;
using System.Collections.Generic;

namespace CodenamesService
{
    public class CodenamesConfiguration : GameConfiguration
    {
        public CodenamesConfiguration()
        {
            // Game Version
            this.Add(new ConfigurationSet()
            {
                Title = "Game Version",
                Description = "Select which version of Codenames is used.",
                SelectionType = SelectionType.Dropdown,
                Options = new List<string>()
                {
                    "Original",
                    "Deep Undercover",
                    "Pictures"
                },
                Selected = 0
            });
        }
    }
}