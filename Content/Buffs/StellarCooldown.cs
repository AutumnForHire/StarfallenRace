using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StarfallenRace.Content.Buffs
{
    public class StellarCooldown : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Stellar Cooldown");
            Description.SetDefault("Stellar Speed is on cooldown and can't be used right now.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
            canBeCleared = false;
            Main.persistentBuff[Type] = true;
        }
    }
}
    
    