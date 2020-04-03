using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.PostalLoads.Games;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.PostalLoads
{
	public partial class PostalLoadsSettings : UserControl
	{
		public bool AutoStart { get; set; }
		public bool AutoReset { get; set; }
		public bool AutoSplitP2 { get; set; }

		const bool DEFAULT_AUTOSTART = true;
		const bool DEFAULT_AUTORESET = true;
		const bool DEFUALT_AUTOSPLIT_P2 = true;

		LiveSplitState _state;

		public PostalLoadsSettings(LiveSplitState state)
		{
			// Dock = DockStyle.Fill;
			InitializeComponent();

			_state = state;

			chkGenAutoStart.DataBindings.Add(nameof(CheckBox.Checked), this, nameof(AutoStart), false, DataSourceUpdateMode.OnPropertyChanged);
			chkGenAutoReset.DataBindings.Add(nameof(CheckBox.Checked), this, nameof(AutoReset), false, DataSourceUpdateMode.OnPropertyChanged);
			chkP2AutoSplit.DataBindings.Add(nameof(CheckBox.Checked), this, nameof(AutoSplitP2), false, DataSourceUpdateMode.OnPropertyChanged);

			// defaults
			AutoStart = DEFAULT_AUTOSTART;
			AutoReset = DEFAULT_AUTORESET;
			AutoSplitP2 = DEFUALT_AUTOSPLIT_P2;
		}

		public XmlNode GetSettings(XmlDocument doc)
		{
			XmlElement settingsNode = doc.CreateElement("Settings");

			settingsNode.AppendChild(SettingsHelper.ToElement(doc, "Version", Assembly.GetExecutingAssembly().GetName().Version.ToString(3)));
			settingsNode.AppendChild(SettingsHelper.ToElement(doc, "AutoStart", AutoStart));
			settingsNode.AppendChild(SettingsHelper.ToElement(doc, "AutoReset", AutoReset));
			settingsNode.AppendChild(SettingsHelper.ToElement(doc, "AutoReset", AutoSplitP2));

			return settingsNode;
		}

		public void SetSettings(XmlNode settings)
		{
			var element = (XmlElement)settings;

			AutoStart = SettingsHelper.ParseBool(settings["AutoStart"], DEFAULT_AUTOSTART);
			AutoReset = SettingsHelper.ParseBool(settings["AutoReset"], DEFAULT_AUTORESET);
			AutoReset = SettingsHelper.ParseBool(settings["AutoReset"], DEFUALT_AUTOSPLIT_P2);
        }
	}
}
