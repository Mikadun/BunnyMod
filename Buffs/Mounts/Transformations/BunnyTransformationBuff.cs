using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BunnyMod;
using BunnyMod.Mounts.Transformations;

namespace BunnyMod.Buffs.Mounts.Transformations
{
    class BunnyTransformationBuff : ModBuff
    {
        public override void SetDefaults()
        {
            this.DisplayName.SetDefault("Bunny");
            this.Description.SetDefault("You're a cutie one");
            Main.buffNoTimeDisplay[this.Type] = true;
            Main.buffNoSave[this.Type] = false;
            Main.debuff[this.Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(ModContent.MountType<BunnyTransformation>(), player, false);
            player.buffTime[buffIndex] = 10;
            player.GetModPlayer<BunnyPlayer>().transformation = true;
        }

        public BunnyTransformationBuff() : base()
        {
            return;
        }
    }
}
