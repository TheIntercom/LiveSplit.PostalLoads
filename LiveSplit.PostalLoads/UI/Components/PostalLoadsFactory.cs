using LiveSplit.Model;
using System;
using System.Reflection;

namespace LiveSplit.UI.Components
{
    public class PostalLoadsFactory : IComponentFactory
    {
        public string ComponentName => "PostalLoads";

        public string Description => "Autosplitting and load removal component for Postal 2, Apocalypse Weekend, and Paradise Lost";

        public ComponentCategory Category => ComponentCategory.Control;

        public IComponent Create(LiveSplitState state) => new PostalLoadsComponent(state);

        public string UpdateName => ComponentName;

        public Version Version => Assembly.GetExecutingAssembly().GetName().Version;

        public string UpdateURL => "https://raw.githubusercontent.com/TheIntercom/LiveSplit.PostalLoads/master/";

        public string XMLURL => "Components/update.LiveSplit.PostalLoads.xml";
    }
}
