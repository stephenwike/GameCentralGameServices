using System.Collections.Generic;

namespace Configuration
{
    public class ConfigurationSet
    {
        public string Title;
        public string Description;
        public SelectionType SelectionType;
        public List<string> Options;
        public int Selected;

        public ConfigurationSet()
        {
            Options = new List<string>();
        }
    }
}