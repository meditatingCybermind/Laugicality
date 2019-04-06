using Terraria;
using Terraria.ModLoader;

namespace Laugicality.Buffs
{
	public class DestructionBoost : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Destruction Power");
			Description.SetDefault("'Hell's energy strengthens you.'\n+10% Mystic Damage");
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetModPlayer<LaugicalityPlayer>(mod).mysticDamage += 0.1f;
        }
        
	}
}
