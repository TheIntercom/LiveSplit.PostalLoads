using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.PostalLoads
{
	public class PostalLoadsComponent : LogicComponent
	{
		public override string ComponentName => "PostalLoads";

		public PostalLoadsSettings Settings { get; set; }

		TimerModel _timer;
		GameMemory _gameMemory;
		LiveSplitState _state;
		HashSet<string> _splitHistory;

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
			if (Settings.AutoStart)
			{
				Debug.WriteLine($"[NoLoads] onMapChange -> {prevMap} to {nextMap}");

				// starting monday + no intro and IL runs of the rest of the week as well, score
				if (prevMap == "Startup" && nextMap == "suburbs-3" && _state.CurrentPhase == TimerPhase.NotRunning)
				{
					_timer.Start();
				}
			}

			if (Settings.AutoSplitP2)
			{
				// hacky but lets us keep traditional timing for splitting in postal 2
				if (nextMap == "homeatnight")
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
