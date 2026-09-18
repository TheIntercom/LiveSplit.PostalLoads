# LiveSplit.PostalLoads
LiveSplit component that provides load removal and autosplitting for Postal 2, Apocalypse Weekend, and Paradise Lost.

### Automatic Installation (Recommended)
1. Run LiveSplit, right-click the timer, and select **Edit Splits**
2. Change the **Game Name** to `Postal 2`, `Postal 2: Apocalypse Weekend`, or `Postal 2: Paradise Lost`
3. Click `Activate`

### Manual Installation
1. Take the .dll from the 'Component' folder and place it in the component folder in the LiveSplit directory.
2. Right-click LiveSplit and **Edit Splits**
3. Change the **Game Name** to 'Postal 2'
4. Right-click LiveSplit and **Edit Layout**
5. Add a new **Control** element and select 'PostalLoads'
6. Right-click and **Compare Against -> Game Time**

### Features
#### Auto Reset
Resets the timer when the intro cinematic begins loading.
- `Apocalypse Weekend` -> Only if **Week Runs** is **off**
- `Paradise Lost` -> Only if **Week Runs** is **off**
##### Week Runs
Prevents the AW and PL intro cinematic cutscenes from resetting the timer to allow for AWP and TWP runs.
#### Auto Start
Starts the timer when we begin a new game (on any day of the week), but only if the timer is reset.
#### Auto Split
Splits the timer when we begin loading a specific map.
- `Postal 2` -> When end-of-night cutscene begins loading *(5 segments)*
- `Apocalypse Weekend` -> When a new map begins loading that is not `awstartup` or `hospital` or `moviepigeon` *(21 segments)*
- `Paradise Lost` -> When a new day begins loading, the start of Showdown, the start of Apocalypse, Outro cutscene begins *(7 segments)*
- `Corkscrew Rules` -> When a new day begins loading, Outro cutscene begins *(4 segments)*
- `Eternal Damnation` -> When a new map begins loading that is not `startup` or `ed_ss_basement` or `1` *(22 segments)*

### Changelog
#### 1.3.1
- The autoupdate should finally work... Part 2.

#### 1.3.0
- PostalLoads now has much better support for old versions of Postal 2!
- Added full support for Corkscrew Rules and Eternal Damnation.
- The autoupdate should finally work...

#### 1.2.0
- Added full support for Apocalypse Weekend and Paradise Lost.
- Updated the menu to reflect these changes.
- Added full support for AWP and TWP runs.
- Added a "Week Runs" setting which suppresses auto reset from triggering during the AW and PL intro cutscenes.

#### 1.1.0
- Added basic support for 5100 and xPatch ILs.

#### 1.0.0
- Initial release

### Contact
* [Twitter](https://twitter.com/MrTheIntercom)

### Credits
- This repository is based on Dalet's original repository (<a href="https://github.com/Dalet/LiveSplit.UnrealLoads">LiveSplit.UnrealLoads</a>)
