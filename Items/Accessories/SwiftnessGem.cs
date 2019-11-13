using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnigmaLite.Items.Accessories
{
    public class SwiftnessGem : LaugicalityItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("+25% Movement speed");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 28;
            item.value = 100;
            item.rare = ItemRarityID.Green;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += 0.25f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(290, 15);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}