
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnigmaLite.Items.Accessories
{
    public class HolyStone : LaugicalityItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Take less damage from cold sources \nIncreases heart pickup range \nIncreases life regeneration \n+1 Max Minion \nIncreases max life by 30% \nEquip in last slot for maximum effectiveness");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 1000;
            item.rare = ItemRarityID.LightRed;
            item.accessory = true;
            item.lifeRegen = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.maxMinions++;
            player.resistCold = true;
            player.lifeMagnet = true;
            player.statLifeMax2 += (player.statLifeMax + player.statLifeMax2) / 5 / 30 * 30 - (player.statLifeMax / 5 / 30 * 30);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "LebenCrystal", 1);
            recipe.AddIngredient(null, "VerteCrystal", 1);
            recipe.AddIngredient(null, "AuraGem", 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}