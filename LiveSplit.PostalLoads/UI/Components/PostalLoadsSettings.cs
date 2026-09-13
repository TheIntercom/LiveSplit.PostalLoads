using LiveSplit.Model;
using LiveSplit.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class PostalLoadsSettings : UserControl
    {
        public bool AutoStart { get; set; }
        public bool AutoReset { get; set; }
        public bool AutoSplit { get; set; }
        public bool WeekRuns { get; set; }

        const bool DEFAULT_AUTOSTART = true;
        const bool DEFAULT_AUTORESET = true;
        const bool DEFUALT_AUTOSPLIT = true;
        const bool DEFUALT_WEEKRUNS = true;

        LiveSplitState _state;

        public PostalLoadsSettings(LiveSplitState state)
        {
            // Dock = DockStyle.Fill;
            InitializeComponent();

            _state = state;

            chkGenAutoStart.DataBindings.Add(nameof(CheckBox.Checked), this, nameof(AutoStart), false, DataSourceUpdateMode.OnPropertyChanged);
            chkGenAutoReset.DataBindings.Add(nameof(CheckBox.Checked), this, nameof(AutoReset), false, DataSourceUpdateMode.OnPropertyChanged);
            chkGenAutoSplit.DataBindings.Add(nameof(CheckBox.Checked), this, nameof(AutoSplit), false, DataSourceUpdateMode.OnPropertyChanged);
            chkGenWeekRuns.DataBindings.Add(nameof(CheckBox.Checked), this, nameof(WeekRuns), false, DataSourceUpdateMode.OnPropertyChanged);

            // defaults
            AutoStart = DEFAULT_AUTOSTART;
            AutoReset = DEFAULT_AUTORESET;
            AutoSplit = DEFUALT_AUTOSPLIT;
            WeekRuns = DEFUALT_WEEKRUNS;
        }

        public XmlNode GetSettings(XmlDocument doc)
        {
            XmlElement settingsNode = doc.CreateElement("Settings");

            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "Version", Assembly.GetExecutingAssembly().GetName().Version.ToString(3)));
            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "AutoStart", AutoStart));
            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "AutoReset", AutoReset));
            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "AutoSplit", AutoSplit));
            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "WeekRuns", WeekRuns));

            return settingsNode;
        }

        public void SetSettings(XmlNode settings)
        {
            var element = (XmlElement)settings;

            AutoStart = SettingsHelper.ParseBool(settings["AutoStart"], DEFAULT_AUTOSTART);
            AutoReset = SettingsHelper.ParseBool(settings["AutoReset"], DEFAULT_AUTORESET);
            AutoSplit = SettingsHelper.ParseBool(settings["AutoSplit"], DEFUALT_AUTOSPLIT);
            WeekRuns = SettingsHelper.ParseBool(settings["WeekRuns"], DEFUALT_WEEKRUNS);
        }

        private void chkGenAutoReset_CheckedChanged(object sender, EventArgs e)
        {
            chkGenWeekRuns.Enabled = !chkGenWeekRuns.Enabled;
        }
    }
}
