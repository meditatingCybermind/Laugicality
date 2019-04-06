using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Laugicality.Items.Weapons.Mystic
{
	public class GreatGladius : MysticItem
    {
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gladius of The Great Moldyrian");
            Tooltip.SetDefault("Praise the gods\nIlusion inflicts 'Daybroken'\nAttacks differently projectiles based on Mysticism");
        }

		public override void SetMysticDefaults()
		{
			item.damage = 1500;
            item.width = 70;
			item.height = 70;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.noMelee = false;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 6f;
            item.scale = 1.5f;
		}
        
        public override bool MysticShoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            LaugicalityPlayer modPlayer = player.GetModPlayer<LaugicalityPlayer>(mod);
            if (modPlayer.mysticMode != 1)
                return true;
            else return false;
        }

        public override void Destruction(LaugicalityPlayer modPlayer)
        {
            item.damage = 2000;
            item.useTime = 26; ;
            item.useAnimation = item.useTime;
            item.knockBack = 8;
            item.shootSpeed = 4f;
            item.shoot = mod.ProjectileType("Nothing");
            item.scale = 2.25f;
        }

        public override void Illusion(LaugicalityPlayer modPlayer)
        {
            item.damage = 1500;
            item.useTime = 20;
            item.useAnimation = 20;
            item.knockBack = 4;
            item.shootSpeed = 12f;
            item.shoot = ProjectileID.Daybreak;
            item.scale = 1.5f;
        }

        public override void Conjuration(LaugicalityPlayer modPlayer)
        {
            item.damage = 1000;
            item.useTime = 45;
            item.useAnimation = 45;
            item.knockBack = 2;
            item.shootSpeed = 8f;
            item.shoot = mod.ProjectileType("Nothing");
            item.scale = 2f;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            LaugicalityPlayer modPlayer = player.GetModPlayer<LaugicalityPlayer>(mod);
            if(modPlayer.mysticMode == 2)
                target.AddBuff(BuffID.Daybreak, (int)(4 * 60 * modPlayer.mysticDuration));
            if (modPlayer.mysticMode == 3)
            {
                if(Main.player[Main.myPlayer] == player && player.ownedProjectileCounts[mod.ProjectileType("GreatGladiusConjuration1")] < 2)
                    Projectile.NewProjectile(target.Center.X, target.Center.Y, 0f, 0f, mod.ProjectileType("GreatGladiusConjuration1"), damage, knockback, Main.myPlayer);
            }
        }
        /*
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3467, 16);
            recipe.AddIngredient(null, "GalacticFragment", 8);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/
    }
}