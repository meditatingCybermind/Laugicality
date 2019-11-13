using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnigmaLite.Items.Accessories
{
    public class SuperManaGem : LaugicalityItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("+80 Mana");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 28;
            item.value = 100;
            item.rare = ItemRarityID.LightPurple;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax2 += 80;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2209, 4);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}