using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
using BunnyMod.Mounts.Transformations;
using BunnyMod.Buffs.Mounts.Transformations;

namespace BunnyMod
{
    public class BunnyPlayer : ModPlayer
    {
        public bool transformation;
        public bool explosiveBunnyTransformation;
        public int explosiveBunnyExplosionDamage;

        public override void ResetEffects()
        {
            transformation = false;
            explosiveBunnyTransformation = false;
            explosiveBunnyExplosionDamage = 250;
        }

        public override void OnRespawn(Player player)
        {
            player.AddBuff(ModContent.BuffType<ExplosiveBunnyTransformationBuff>(), 10, true);
        }

        public override void OnEnterWorld(Player player)
        {
            OnRespawn(player);
        }

        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            if (explosiveBunnyTransformation)
            {
                Projectile.NewProjectile(player.position, Vector2.Zero, ProjectileID.Explosives, explosiveBunnyExplosionDamage, player.whoAmI);
            }

            base.Kill(damage, hitDirection, pvp, damageSource);
        }

        public override void ModifyDrawLayers(List<PlayerLayer> layers)
        {
            // if transformed make invisible all layers except mount and misc effects
            if (transformation)
            {
                foreach (PlayerLayer layer in layers)
                {
                    if (layer != PlayerLayer.MountBack 
                     && layer != PlayerLayer.MountFront 
                     && layer != PlayerLayer.MiscEffectsFront 
                     && layer != PlayerLayer.MiscEffectsBack)
                    {
                        layer.visible = false;
                    }
                }
            }
        }
    }
}