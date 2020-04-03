using LiveSplit.ComponentUtil;
using LiveSplit.Options;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace LiveSplit.PostalLoads.Games
{
	class Postal2 : GameSupport
	{
		public override HashSet<string> GameNames => new HashSet<string>
		{
			"Postal 2"
		};

		public override HashSet<string> ProcessNames => new HashSet<string>
		{
			"postal2"
		};

		public override string MapExtension { get; } = ".fuk";

		public override HashSet<string> Maps => new HashSet<string>
		{
			"AWstartup",
			"AWstartuplogo",
			"Brewery",
			"Bridge",
			"Church",
			"CowPasture",
			"Credits",
			"DogPound",
			"EasterArena",
			"EastMall",
			"ElephantPreserve",
			"Entry",
			"Estate",
			"forest",
			"Gayfish",
			"Gayfish2",
			"Greenbelt1",
			"Greenbelt2",
			"Highlands",
			"HomeAtNight",
			"Hospital",
			"Industry",
			"Industry2",
			"intro",
			"Junkyard",
			"library1",
			"library2",
			"LowerParadise",
			"LowerParadise2",
			"LowerParadise3",
			"MilitaryBase",
			"MilitaryBase2",
			"MilitaryBase3",
			"MilitaryBase4",
			"MovieIntro",
			"MovieOutro",
			"MoviePigeons",
			"Napalm",
			"ngt-Brewery",
			"ngt-Church",
			"ngt-Compound",
			"ngt-EasterArena",
			"ngt-EastMall",
			"ngt-forest",
			"ngt-Greenbelt1",
			"ngt-Greenbelt2",
			"ngt-Highlands",
			"ngt-HomeAtNight",
			"ngt-Industry",
			"ngt-Industry2",
			"ngt-intro",
			"ngt-Junkyard",
			"ngt-library1",
			"ngt-library2",
			"ngt-Napalm",
			"ngt-parade",
			"ngt-parcelcenter",
			"ngt-police",
			"ngt-rwsblock",
			"ngt-slaughterhouse",
			"ngt-suburbs-1",
			"ngt-suburbs-2",
			"ngt-suburbs-3",
			"ngt-suburbs-4",
			"ngt-ToraBora",
			"ngt-underhub",
			"ngt-WestMall",
			"parade",
			"parcelcenter",
			"police",
			"rwsblock",
			"slaughterhouse",
			"Startup-Halloween",
			"Startup-MP",
			"Startup",
			"Startuplogo",
			"StartupMovie",
			"Suburbs-1",
			"Suburbs-2",
			"Suburbs-3",
			"Suburbs-4",
			"TestSubtitlesSpam",
			"ToraBora",
			"TrainingCamp-part1",
			"TrainingCamp-part2",
			"TrainingCamp-part3",
			"TrainingCamp2",
			"TrainingCamp3",
			"TrainingCamp4",
			"underhub",
			"VincesHouse",
			"WestMall"
		};

		StringWatcher _map;

		public override LoadMapDetour GetNewLoadMapDetour() => new LoadMapDetour_Postal2();
		public override SaveGameDetour GetNewSaveGameDetour() => new SaveGameDetour_Postal2();

		public override TimerAction[] OnUpdate(Process game, MemoryWatcherList watchers)
		{
			var status = (MemoryWatcher<int>)watchers["status"];
			_map = (StringWatcher)watchers["map"];

			if (status.Changed)
			{
				var map = Path.GetFileNameWithoutExtension(_map.Current).ToLower();

				if (status.Old == (int)Status.LoadingMap)
				{
					if (map == "intro")
						return new TimerAction[] { TimerAction.Start };
				}
				else if (status.Current == (int)Status.LoadingMap)
				{
					if (map == "intro")
						return new TimerAction[] { TimerAction.Reset };
				}
			}
			return null;
		}

		public class LoadMapDetour_Postal2 : LoadMapDetour
		{
			public override string Symbol => "?LoadMap@UGameEngine@@UAEPAVULevel@@ABVFURL@@PAV3@PAVUPendingLevel@@PBV?$TMap@VFString@@V1@@@AAVFString@@@Z";

			public override byte[] GetBytes()
			{
				var status = StatusPtr.ToBytes().ToHex();
				var none = Status.None.ToBytes().ToHex();
				var loadingMap = Status.LoadingMap.ToBytes().ToHex();

				var str = string.Join("\n",
					"55",
					"8b ec",
					"56",
					"8b 75 08",
					"57",
					"8b f9",
					"ff 76 1c",
					"#00 00 00 00 00",
					"83 c4 04",
					"c7 05" + status + loadingMap,
					"8b cf",
					"ff 75 18",
					"ff 75 14",
					"ff 75 10",
					"ff 75 0c",
					"56",
					"#00 00 00 00 00",
					"5f",
					"c7 05" + status + none,
					"5e",
					"5d",
					"c2 14 00"
				);

				var bytes = Utils.ParseBytes(str, out var offsets);
				_setMapCallOffset = offsets[0];
				_originalFuncCallOffset = offsets[1];

				return bytes.ToArray();
			}

		}

		public class SaveGameDetour_Postal2 : SaveGameDetour
		{
			public override string Symbol => "?SaveGame@UGameEngine@@UAEHH@Z";
		}

		}
	}
