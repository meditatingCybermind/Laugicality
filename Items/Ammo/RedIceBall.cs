﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Laugicality.Items.Ammo
{
    public class RedIceBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Iceball");
            Tooltip.SetDefault("The crimson ice is much heavier, and more damaging.");
        }

        public override void SetDefaults()
        {
            item.damage = 18;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 7f;
            item.value = 0;
            item.rare = 0;
            item.shoot = mod.ProjectileType("RedIceBall");
            item.shootSpeed = 8f;
            item.ammo = AmmoID.Snowball;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RedIceBlock, 1);
            recipe.SetResult(this, 12);
            recipe.AddRecipe();
        }
    }
}
