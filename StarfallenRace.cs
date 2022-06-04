using Terraria.ModLoader;

namespace StarfallenRace
{
	public class StarfallenRace : Mod
	{
		public static StarfallenRace Instance { get; private set; }
		public override void Load ()
        {
			MrPlagueRaces.Core.Loadables.LoadableManager.Autoload(this);
        }
		public override void Unload()
        {
			MrPlagueRaces.Common.Races.RaceLoader.Races.Clear();
			MrPlagueRaces.Common.Races.RaceLoader.RacesByLegacyIds.Clear();
			MrPlagueRaces.Common.Races.RaceLoader.RacesByFullNames.Clear();
        }
	}
}