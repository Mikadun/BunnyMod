using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BunnyMod.NPCs.Bunnies
{
    public abstract class BaseBunnyNPC : ModNPC
    {
        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.Bunny);
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Bunny];
            animationType = NPCID.Bunny;
        }
    }
}
