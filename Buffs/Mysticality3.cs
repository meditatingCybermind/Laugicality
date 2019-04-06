﻿using Terraria;
using Terraria.ModLoader;
using Laugicality.NPCs;

namespace Laugicality.Buffs
{
    public class Mysticality3 : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Volatile Mysticality");
            Description.SetDefault("You can't drink Potentia Potions for a while.\n+20% Overflow");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = false;
            canBeCleared = false;
        }


        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<LaugicalityPlayer>(mod).mysticality = 2;
            player.GetModPlayer<LaugicalityPlayer>(mod).globalOverflow += .2f;
        }
    }
}
