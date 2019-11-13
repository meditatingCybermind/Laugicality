using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnigmaLite.Items.Accessories
{
    public class AncientRelic : LaugicalityItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Mastery of the world");
        }

        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 48;
            item.value = 10000;
            item.rare = ItemRarityID.Yellow;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lavaImmune = true;
            player.fireWalk = true;
            player.buffImmune[24] = true;
            player.waterWalk = true;
            player.gills = true;
            player.ignoreWater = true;
            player.accFlipper = true;
            player.cratePotion = true;
            player.sonarPotion = true;
            player.fishingSkill += 15;
            player.tileSpeed += 0.25f;
            player.wallSpeed += 0.25f;
            player.blockRange++;
            player.pickSpeed -= 0.25f;
            player.slowFall = true;
            player.moveSpeed += 0.25f;
            player.endurance += 0.10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AlterationStone", 1);
            recipe.AddIngredient(null, "AquaStone", 1);
            recipe.AddTile(TileID.CrystalBall);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}