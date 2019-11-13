using Terraria.ID;
using Terraria.ModLoader;

namespace EnigmaLite.Items.Accessories
{
    public class RecallGem : LaugicalityItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'It's power isn't complete yet'");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 28;
            item.value = 100;
            item.rare = ItemRarityID.Green;
            item.accessory = true;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2350, 4);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();


            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(170, 8); //Glass
            recipe1.AddIngredient(null, "RecallGem");
            recipe1.AddIngredient(109); //Mana Crystal
            recipe1.AddTile(TileID.AlchemyTable);
            recipe1.SetResult(50); //Magic Mirror
            recipe1.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(170, 8); //Glass
            recipe2.AddIngredient(664, 8); //Ice
            recipe2.AddIngredient(null, "RecallGem");
            recipe2.AddIngredient(109); //Mana Crystal
            recipe2.AddTile(TileID.AlchemyTable);
            recipe2.SetResult(3199); //Ice Mirror
            recipe2.AddRecipe();
        }
    }
}