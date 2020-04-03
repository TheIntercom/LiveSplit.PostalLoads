using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Reflection;

namespace LiveSplit.PostalLoads
{
	public class PostalLoadsFactory : IComponentFactory
	{
		public string ComponentName => "PostalLoads";

		public string Description => "Autosplitting and load removal component for Postal 2";

		public ComponentCategory Category => ComponentCategory.Control;

		public IComponent Create(LiveSplitState state) => new PostalLoadsComponent(state);

		public string UpdateName => ComponentName;

		public Version Version => Assembly.GetExecutingAssembly().GetName().Version;

		public string UpdateURL => "";

		public string XMLURL => "";
	}
}
