﻿using Laugicality.Dusts;
using Laugicality.Items.Loot;
using Laugicality.Items.Materials;
using Laugicality.Items.Placeable;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Laugicality.Items.Equipables
{
    public class DemonsparkBoots : LaugicalityItem
    {
        int dashDelay = 0;
        int dashCooldown = 0;
        int jumpDashes = 0;
        int trail = 0;
        int dashDir = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hellspark Boots");
            Tooltip.SetDefault("Allows the wearer to dash\nIncreased movement speed\nCan dash multiple times in the air");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = 100;
            item.rare = ItemRarityID.Orange;
            item.accessory = true;
            item.defense = 4;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += .2f;

            float dashSpeed = 14;
            int dashCooldownMax = 60;
            int trailLength = 45;
            int verticalCooldownMax = 45;
            int maxJumps = 3;

            if (!player.mount.Active && player.grappling[0] == -1 && dashCooldown <= 0)
            {
                if (player.controlRight && player.releaseRight)
                {
                    if (dashDelay > 0 && dashDir == 1)
                    {
                        dashCooldown = dashCooldownMax;
                        trail = trailLength;
                        player.velocity.X = dashSpeed;
                        player.GetModPlayer<LaugicalityPlayer>().DustBurst(mod.DustType<Magma>(), 20);
                        dashDir = 0;
                    }
                    else
                    {
                        dashDelay = 15;
                        dashDir = 1;
                    }
                }
                if (player.controlLeft && player.releaseLeft)
                {
                    if (dashDelay > 0 && dashDir == 2)
                    {
                        dashCooldown = dashCooldownMax;
                        trail = trailLength;
                        player.velocity.X = -dashSpeed;
                        player.GetModPlayer<LaugicalityPlayer>().DustBurst(mod.DustType<Magma>(), 20);
                        dashDir = 0;
                    }
                    else
                    {
                        dashDelay = 15;
                        dashDir = 2;
                    }
                }
                if (player.controlDown && player.releaseDown)
                {
                    if (dashDelay > 0 && dashDir == 3)
                    {
                        dashCooldown = verticalCooldownMax;
                        trail = trailLength;
                        player.velocity.Y = 2 * dashSpeed;
                        player.GetModPlayer<LaugicalityPlayer>().DustBurst(mod.DustType<Magma>(), 40);
                        player.fallStart = (int)player.position.Y / 16;
                        dashDir = 0;
                    }
                    else
                    {
                        dashDelay = 15;
                        dashDir = 3;
                    }
                }
                if (player.controlUp && player.releaseUp)
                {
                    if (dashDelay > 0 && jumpDashes < maxJumps && dashDir == 4)
                    {
                        dashCooldown = verticalCooldownMax;
                        trail = trailLength;
                        player.velocity.Y = -dashSpeed;
                        player.GetModPlayer<LaugicalityPlayer>().DustBurst(mod.DustType<Magma>(), 40);
                        player.fallStart = (int)player.position.Y / 16;
                        jumpDashes++;
                        dashDir = 0;
                    }
                    else
                    {
                        dashDelay = 15;
                        dashDir = 4;
                    }
                }
            }
            if (dashDelay > 0)
                dashDelay--;
            if (dashCooldown > 0)
                dashCooldown--;
            if (trail > 0)
            {
                trail--;
                player.GetModPlayer<LaugicalityPlayer>().DustTrail(mod.DustType<Magma>(), 1);
            }
            if (Main.tileSolid[Main.tile[(int)(player.Center.X / 16), (int)(player.Center.Y / 16) + 2].type] && Main.tile[(int)(player.Center.X / 16), (int)(player.Center.Y / 16) + 2].type != 0)
                jumpDashes = 0;
            if (player.grappling[0] != -1)
                jumpDashes = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType<DemonrushBoots>(), 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 8);
            recipe.AddIngredient(mod.ItemType<LavaGem>(), 8);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}