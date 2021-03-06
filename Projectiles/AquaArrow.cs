﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace prismmod.Projectiles
{
    public class AquaArrow : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aqua Arrow");
        }

        public override void SetDefaults()
        {
            projectile.arrow = true;
            projectile.width = 10;
            projectile.height = 10;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.ranged = true;
            aiType = ProjectileID.WoodenArrowFriendly;
        }

        public override void AI()
        {
            Player owner = Main.player[projectile.owner];
            float speedX = projectile.velocity.X;
            float speedY = projectile.velocity.Y;
            if (projectile.timeLeft % 15 == 0)
            {
                Projectile.NewProjectile(projectile.position.X + speedX, projectile.position.Y +
                    speedY, speedX, speedY, 90, (int)(projectile.damage * 0.5), 0f, projectile.owner, 0f, 0f);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0f, 0f, mod.ProjectileType("RainDroplet"),
                    10, 0f, owner.whoAmI);
            }
        }
    }
}