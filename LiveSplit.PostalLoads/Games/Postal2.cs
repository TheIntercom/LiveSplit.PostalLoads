using LiveSplit.ComponentUtil;
using LiveSplit.Options;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static LiveSplit.PostalLoads.Games.Postal2;

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
			"paradiselost",
            "eternaldamnation"
		};

		public override string MapExtension { get; } = ".fuk";

        private LoadMapDetour _lmd = null;
        private SaveGameDetour _sgd = null;

		public override LoadMapDetour GetNewLoadMapDetour() => _lmd;
		public override SaveGameDetour GetNewSaveGameDetour() => _sgd;

        // most of the logic involving auto-split and auto-start are handled by the component file for legacy timing reasons
        // public override TimerAction[] OnUpdate(Process game, MemoryWatcherList watchers) { }

        private static bool CanFindExportedFunc(Detour detour, Process process) => detour.FindExportedFunc(process) != IntPtr.Zero;

        public override IdentificationResult IdentifyProcess(Process process)
        {
            var old_load = new LoadMapDetour_OldPostal2();
            var old_save = new SaveGameDetour_OldPostal2();

            var new_load = new LoadMapDetour_Postal2();
            var new_save = new SaveGameDetour_Postal2();

            if (CanFindExportedFunc(old_load, process) && CanFindExportedFunc(old_save, process))
            {
                _lmd = old_load;
                _sgd = old_save;
            }
            else if (CanFindExportedFunc(new_load, process) && CanFindExportedFunc(new_save, process))
            {
                _lmd = new_load;
                _sgd = new_save;
            }
            else if (CanFindExportedFunc(new_load, process) && CanFindExportedFunc(old_save, process))
            {
                _lmd = new_load;
                _sgd = old_save;
            }
            else
            {
                return IdentificationResult.Failure;
            }

            return IdentificationResult.Success;
        }
        public class LoadMapDetour_OldPostal2 : LoadMapDetour
        {
            public override string Symbol => "?LoadMap@UGameEngine@@UAEPAVULevel@@ABVFURL@@PAVUPendingLevel@@PBV?$TMap@VFString@@V1@@@AAVFString@@@Z";
            public override byte[] GetBytes()
            {
                var status = StatusPtr.ToBytes().ToHex();
                var none = Status.None.ToBytes().ToHex();
                var loadingMap = Status.LoadingMap.ToBytes().ToHex();
                var str = string.Join("\n",
                    "55",                              // push ebp
                    "8b ec",                           // mov ebp, esp
                    "56",                              // push esi
                    "8b 75 08",                        // mov esi, [ebp+08]
                    "57",                              // push edi
                    "8b f9",                           // mov edi, ecx
                    "ff 76 1c",                        // push [esi+1c]
                    "#00 00 00 00 00",                 // call <placeholder_1>
                    "83 c4 04",                        // add esp, 4
                    "c7 05" + status + loadingMap,     // mov [status], loadingMap
                    "8b cf",                           // mov ecx, edi
                    "ff 75 14",                        // push [ebp+14]
                    "ff 75 10",                        // push [ebp+10]
                    "ff 75 0c",                        // push [ebp+0c]
                    "56",                              // push esi
                    "#00 00 00 00 00",                 // call <placeholder_2>
                    "5f",                              // pop edi
                    "c7 05" + status + none,           // mov [status], none
                    "5e",                              // pop esi
                    "5d",                              // pop ebp
                    "c2 10 00"                         // ret 10
                );

                var bytes = Utils.ParseBytes(str, out var offsets);
                _setMapCallOffset = offsets[0];
                _originalFuncCallOffset = offsets[1];

                return bytes.ToArray();
            }
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

        public class SaveGameDetour_OldPostal2 : SaveGameDetour
        {
            public override string Symbol => "?SaveGame@UGameEngine@@UAEXH@Z";
        }

        public class SaveGameDetour_Postal2 : SaveGameDetour
		{
			public override string Symbol => "?SaveGame@UGameEngine@@UAEHH@Z";
        }
	}
}
