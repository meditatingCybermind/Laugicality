﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Laugicality.Items.Consumables
{
	public class EtherialEye : ModItem
    {
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Etherial Crown");
            Tooltip.SetDefault("Summons the Eye of Cthulhu");
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
			item.consumable = true;
			item.shoot = mod.ProjectileType("GeneralBossSpawn");
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("GeneralBossSpawn"), NPCID.EyeofCthulhu, knockBack, player.whoAmI);
            return false;
        }

        public override bool CanUseItem(Player player)
        {
            var modPlayer = player.GetModPlayer<LaugicalityPlayer>(mod);
            return (!Main.dayTime && modPlayer.etherial);
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "EtherialEssence", 1);
            recipe.AddTile(26);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}