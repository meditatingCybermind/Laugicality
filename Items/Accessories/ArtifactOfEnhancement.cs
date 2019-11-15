using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnigmaLite.Items.Accessories
{
    public class ArtifactOfEnhancement : LaugicalityItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Mastery of all");
        }

        public override void SetDefaults()
        {
            item.width = 72;
            item.height = 72;
            item.value = 10000;
            item.rare = ItemRarityID.Red;
            item.accessory = true;
            item.defense = 4;
            item.lifeRegen = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.findTreasure = true;
            Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, 0.8f, 0.95f, 1f);
            player.nightVision = true;
            player.detectCreature = true;
            player.dangerSense = true;
            player.slowFall = true;
            player.maxMinions++;
            player.resistCold = true;
            player.lifeMagnet = true;
            player.statLifeMax2 += (player.statLifeMax + player.statLifeMax2) / 5 / 30 * 30 - (player.statLifeMax / 5 / 30 * 30);
            player.lifeRegen = (int)(player.lifeRegen * 1.1f);            
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
            player.moveSpeed += 0.25f;
            player.endurance += 0.20f;
            player.allDamage += 0.20f;
            player.meleeCrit += 20;
            player.rangedCrit += 20;
            player.magicCrit += 20;
            player.thrownCrit += 20;
            player.manaRegenBonus += 35;
            player.manaRegenDelayBonus += 5;
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
            recipe.AddIngredient(null, "AncientRelic", 1);
            recipe.AddIngredient(null, "CursedRelic", 1);
            recipe.AddIngredient(null, "HallowedRelic", 1);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}