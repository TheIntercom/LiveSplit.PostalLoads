using LiveSplit.ComponentUtil;
using LiveSplit.UI.Components;
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
			"postal2",
			"paradiselost"
		};

		public override string MapExtension { get; } = ".fuk";

		public override LoadMapDetour GetNewLoadMapDetour() => new LoadMapDetour_Postal2();
		public override SaveGameDetour GetNewSaveGameDetour() => new SaveGameDetour_Postal2();

		// most of the logic involving auto-split and auto-start are handled by the component file for legacy timing reasons
		// public override TimerAction[] OnUpdate(Process game, MemoryWatcherList watchers) { }

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
