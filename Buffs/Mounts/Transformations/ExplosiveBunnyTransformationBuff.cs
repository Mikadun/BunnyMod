using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BunnyMod;
using BunnyMod.Mounts.Transformations;

namespace BunnyMod.Buffs.Mounts.Transformations
{
    class ExplosiveBunnyTransformationBuff : ModBuff
    {
        public override void SetDefaults()
        {
            this.DisplayName.SetDefault("Explosive Bunny");
            this.Description.SetDefault("You're a deadly little bunny");
            Main.buffNoTimeDisplay[this.Type] = true;
            Main.buffNoSave[this.Type] = false;
            Main.debuff[this.Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(ModContent.MountType<ExplosiveBunnyTransformation>(), player, false);
            player.buffTime[buffIndex] = 10;
            player.GetModPlayer<BunnyPlayer>().transformation = true;
            player.GetModPlayer<BunnyPlayer>().explosiveBunnyTransformation = true;
        }

        public ExplosiveBunnyTransformationBuff() : base()
        {
            return;
        }
    }
}
