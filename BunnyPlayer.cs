using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
using BunnyMod.Mounts.Transformations;

namespace BunnyMod
{
    public class BunnyModPlayer : ModPlayer
    {
        public bool transformation = true;

        public override void OnRespawn(Player player)
        {
            player.mount.SetMount(ModContent.MountType<BunnyTransformation>(), player, false);
        }

        public override void OnEnterWorld(Player player)
        {
            OnRespawn(player);
        }

        private void ReserEffects()
        {
            transformation = true;
        }

        public override void Initialize()
        {
            //OnRespawn(player);
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