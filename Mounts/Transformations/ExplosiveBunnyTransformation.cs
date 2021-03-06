﻿using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BunnyMod.Buffs.Mounts.Transformations;

namespace BunnyMod.Mounts.Transformations
{
    class ExplosiveBunnyTransformation : ModMountData
    {
        public override void SetDefaults()
        {
            Mount.MountData mount = this.mountData;
            mount.buff = ModContent.BuffType<ExplosiveBunnyTransformationBuff>();
            mount.heightBoost = -26;
            mount.fallDamage = 0.25f;
            mount.runSpeed = 2.5f;
            mount.dashSpeed = 3.0f;
            mount.flightTimeMax = 0;
            mount.fatigueMax = 0;
            mount.jumpHeight = 26;
            mount.acceleration = 0.25f;
            mount.jumpSpeed = 6.0f;
            mount.blockExtraJumps = false;
            mount.totalFrames = 7;
            mount.constantJump = false;
            int[] numArray = new int[mount.totalFrames];
            for (int index = 0; index < numArray.Length; ++index)
                numArray[index] = 0;
            mount.playerYOffsets = numArray;
            mount.xOffset = 0;
            mount.bodyFrame = 0;
            mount.yOffset = -8;
            mount.playerHeadOffset = -24;
            mount.standingFrameCount = 1;
            mount.standingFrameDelay = 10;
            mount.standingFrameStart = 0;
            mount.runningFrameCount = 6;
            mount.runningFrameDelay = 15;
            mount.runningFrameStart = 1;
            mount.flyingFrameCount = 1;
            mount.flyingFrameDelay = 0;
            mount.flyingFrameStart = 5;
            mount.inAirFrameCount = 1;
            mount.inAirFrameDelay = 0;
            mount.inAirFrameStart = 5;
            mount.idleFrameCount = 1;
            mount.idleFrameDelay = 10;
            mount.idleFrameStart = 0;
            mount.idleFrameLoop = true;
            mount.swimFrameCount = mount.inAirFrameCount;
            mount.swimFrameDelay = mount.inAirFrameDelay;
            mount.swimFrameStart = mount.inAirFrameStart;
            if (Main.netMode == NetmodeID.Server)
                return;
            mount.textureWidth = mount.backTexture.Width;
            mount.textureHeight = mount.backTexture.Height;
        }

        public ExplosiveBunnyTransformation() : base()
        {
            return;
        }
    }
}
