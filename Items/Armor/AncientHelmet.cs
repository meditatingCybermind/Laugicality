﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Laugicality.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class AncientHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("+10% Mystic, Magic, and Summon damage");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 22;
            item.value = 10000;
            item.rare = 2;
            item.defense = 3;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("AncientArmor") && legs.type == mod.ItemType("AncientGreaves");
        }


        public override void UpdateEquip(Player player)
        {
            LaugicalityPlayer modPlayer = player.GetModPlayer<LaugicalityPlayer>(mod);
            modPlayer.mysticDamage += 0.10f;
            player.minionDamage += .1f;
            player.magicDamage += .1f;
        }
        
        public override void UpdateArmorSet(Player player)
        {
            LaugicalityPlayer modPlayer = player.GetModPlayer<LaugicalityPlayer>(mod);
            player.setBonus = "Innate Sandstorm in a Bottle\n+15% Increased Potentia Conversion\n+60 Mana\nIncreased Max Minions";
            modPlayer.globalAbsorbRate += .15f;
            player.statManaMax2 += 60;
            player.maxMinions += 2;
            player.doubleJumpSandstorm = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Crystilla", 6);
            recipe.AddIngredient(ItemID.DesertFossil, 12);
            recipe.AddTile(16);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}