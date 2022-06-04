using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StarfallenRace.Content.Buffs
{
	public class StellarSpeed : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Stellar Speed");
			Description.SetDefault("You feel as agile as a shooting star");
			Main.buffNoTimeDisplay[Type] = false;
			Main.debuff[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.moveSpeed += 0.50f;
			player.allDamage -= 0.10f;
			player.jumpSpeedBoost += 0.75f;
		}
	}
}