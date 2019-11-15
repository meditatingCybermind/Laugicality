using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnigmaLite.Items.Accessories
{
    public class CursedRelic : LaugicalityItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Cursed? \nMastery of violence");
        }

        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 48;
            item.value = 10000;
            item.rare = ItemRarityID.Yellow;
            item.accessory = true;
            item.defense = 4;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.endurance += 0.10f;
            player.allDamage += 0.20f;
            player.meleeCrit += 20;
            player.rangedCrit += 20;
            player.magicCrit += 20;
            player.thrownCrit += 20;
            player.manaRegenBonus += 35;
            player.player.manaRegenDelayBonus += 5;
            player.magicDamage += 0.20f;
            player.kbBuff = true;
            if (player.thorns < 1f)
            {
                player.thorns = 0.333333343f;
            }
            player.ammoCost80 = true;
            player.rangedDamage += 0.10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "TitanStone", 1);
            recipe.AddIngredient(null, "AggressionStone", 1);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}