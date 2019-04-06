﻿using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Laugicality.Items.Consumables
{
	public class EtherialAwakener : ModItem
    {
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Etherial Crown");
            Tooltip.SetDefault("Summons Dioritus");
        }
        public override void SetDefaults()
		{
			item.width = 16;
			item.height = 20;
			item.maxStack = 20;
			item.rare = 1;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			//item.UseSound = SoundID.Item44;
			item.consumable = true;
			item.shoot = mod.ProjectileType("Nothing");
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("GeneralBossSpawn"), mod.NPCType("Dioritus"), knockBack, player.whoAmI);
            return false;
        }

        public override bool CanUseItem(Player player)
        {
            return (player.ZoneRockLayerHeight && LaugicalityWorld.downedEtheria && NPC.CountNPCS(mod.NPCType("Andesia")) < 1 && NPC.CountNPCS(mod.NPCType("Dioritus")) < 1 && NPC.CountNPCS(mod.NPCType("AnDio3")) < 1);
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "EtherialEssence", 3);
            recipe.AddTile(26);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}