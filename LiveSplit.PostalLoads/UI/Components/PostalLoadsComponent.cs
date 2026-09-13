using LiveSplit.Model;
using LiveSplit.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LiveSplit.UI.Components
{
    public class PostalLoadsComponent : LogicComponent
    {
        public override string ComponentName => "PostalLoads";

        public PostalLoadsSettings Settings { get; set; }

        TimerModel _timer;
        GameMemory _gameMemory;
        LiveSplitState _state;
        HashSet<string> _splitHistory;

        enum AutoSplitBehavior
        {
            EndOfDay,
            EndOfMap
        }

        AutoSplitBehavior _autoSplitBehavior = AutoSplitBehavior.EndOfDay;

        public PostalLoadsComponent(LiveSplitState state)
        {
            bool debug = false;

            #if DEBUG
            debug = true;
            #endif

            Trace.WriteLine("[NoLoads] Using LiveSplit.PostalLoads component version " + Assembly.GetExecutingAssembly().GetName().Version + " " + ((debug) ? "Debug" : "Release") + " build");

            _state = state;
            _timer = new TimerModel { CurrentState = state };
            _splitHistory = new HashSet<string>();

            Settings = new PostalLoadsSettings(_state);

            _state.OnStart += _state_OnStart;

            _gameMemory = new GameMemory();
            _gameMemory.OnReset += gameMemory_OnReset;
            _gameMemory.OnStart += gameMemory_OnStart;
            _gameMemory.OnSplit += _gameMemory_OnSplit;
            _gameMemory.OnLoadStarted += gameMemory_OnLoadStarted;
            _gameMemory.OnLoadEnded += gameMemory_OnLoadEnded;
            _gameMemory.OnMapChange += _gameMemory_OnMapChange;

            _gameMemory.StartMonitoring();
        }

        void _state_OnStart(object sender, EventArgs e)
        {
            _timer.InitializeGameTime();
            _splitHistory.Clear();
        }

        void _gameMemory_OnSplit(object sender, EventArgs e)
        {
            _timer.Split();
        }

        void _gameMemory_OnMapChange(object sender, string prevMap, string nextMap)
        {
            string p = prevMap.ToLower();
            string n = nextMap.ToLower();

            Debug.WriteLine($"[NoLoads] onMapChange -> {p} to {n} -> {(_autoSplitBehavior == AutoSplitBehavior.EndOfDay ? "Day" : "Level")}");

            if (_state.CurrentPhase == TimerPhase.Running)
            {
                // postal 2
                if (n == "intro")
                {
                    _autoSplitBehavior = AutoSplitBehavior.EndOfDay;

                    if (Settings.AutoReset)
                    {
                        _timer.Reset();
                        _timer.Start();
                    }
                }

                // apocalype weekend
                if (n == "movieintro")
                {
                    _autoSplitBehavior = AutoSplitBehavior.EndOfMap; // awp and twp

                    if (Settings.AutoReset && !Settings.WeekRuns)
                    {
                        _timer.Reset();
                        _timer.Start();
                    }
                }

                // paradise lost
                if (n == "pl-intro")
                {
                    _autoSplitBehavior = AutoSplitBehavior.EndOfDay; // awp and twp

                    if (Settings.AutoReset && !Settings.WeekRuns)
                    {
                        _timer.Reset();
                        _timer.Start();
                    }
                }
            }

            if (Settings.AutoStart && _state.CurrentPhase == TimerPhase.NotRunning)
            {
                if (p == "startup" || p == "awstartup" || p == "startup-apocalypse" || p == "startup-halloween")
                {
                    // postal 2 -> monday to friday
                    if (n == "intro" || n == "suburbs-3")
                    {
                        _timer.Start();
                        _autoSplitBehavior = AutoSplitBehavior.EndOfDay;
                    }

                    // aw -> saturday and sunday
                    if (n == "movieintro" || n == "hospital" || n == "vinceshouse")
                    {
                        _timer.Start();
                        _autoSplitBehavior = AutoSplitBehavior.EndOfMap;
                    }

                    // pl -> monday to sunday
                    if (n == "pl-intro"
                        || n == "pl-highlands"
                        || n == "pl-church"
                        || n == "pl-junkyard"
                        || n == "pl-colemancave"
                        || n == "pl-torabora"
                        || n == "pl-hell_ent"
                        || n == "pl-suburbs3")
                    {
                        _timer.Start();
                        _autoSplitBehavior = AutoSplitBehavior.EndOfDay;
                    }
                }
            }

            if (Settings.AutoSplit)
            {
                // postal 2 -> split when end-of-day cutscene is entered
                if (n == "homeatnight")
                {
                    _timer.Split();
                }

                // aw -> split when a new map is entered (but not to the title screen)
                if (_autoSplitBehavior == AutoSplitBehavior.EndOfMap)
                {
                    if ((n != "startup" && n != "awstartup" && n != "startup-apocalypse" && n != "startup-halloween" && n != "movieintro" && n != "hospital")
                        && (n != p))
                    {
                        _timer.Split();
                    }
                }

                // pl -> split when certain maps are entered a specific way
                if ((p == "bridge" && n == "pl-intro")
                    || (p == "pl-endofmonday" && n == "pl-church")
                    || (p == "pl-church" && n == "pl-junkyard")
                    || (p == "pl-junkyardarena" && n == "pl-colemancave")
                    || (p == "pl-endofthursday" && n == "pl-torabora")
                    || (p == "pl-torabora" && n == "pl-hell_ent")
                    || (p == "pl-finalboss" && n == "pl-suburbs-3")
                    || (p == "pl-highlands" && n == "pl-outro"))
                {
                    _timer.Split();
                }
            }
        }

        public override void Dispose()
        {
            _gameMemory?.Stop();
            _state.OnStart -= _state_OnStart;
        }

        void gameMemory_OnReset(object sender, EventArgs e)
        {
            if (Settings.AutoReset)
            {
                _timer.Reset();
            }
        }

        void gameMemory_OnStart(object sender, EventArgs e)
        {
            if (Settings.AutoStart)
            {
                if (_state.CurrentPhase == TimerPhase.NotRunning)
                {
                    _timer.Start();
                }
            }
        }

        void gameMemory_OnLoadStarted(object sender, EventArgs e)
        {
            _state.IsGameTimePaused = true;
        }

        void gameMemory_OnLoadEnded(object sender, EventArgs e)
        {
            _state.IsGameTimePaused = false;
        }

        public override XmlNode GetSettings(XmlDocument document) => Settings.GetSettings(document);

        public override Control GetSettingsControl(LayoutMode mode) => Settings;

        public override void SetSettings(XmlNode settings) => Settings.SetSettings(settings);

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) { }
    }
}
