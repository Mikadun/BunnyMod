using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BunnyMod;
using BunnyMod.Mounts.Transformations;

namespace BunnyMod.Buffs.Mounts.Transformations
{
    class SquirrelTransformationBuff : ModBuff
    {
        public override void SetDefaults()
        {
            this.DisplayName.SetDefault("Squirrel");
            this.Description.SetDefault("You're a looking for nuts");
            Main.buffNoTimeDisplay[this.Type] = true;
            Main.buffNoSave[this.Type] = false;
            Main.debuff[this.Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(ModContent.MountType<SquirrelTransformation>(), player, false);
            player.buffTime[buffIndex] = 10;
            player.GetModPlayer<BunnyPlayer>().transformation = true;
        }

        public SquirrelTransformationBuff() : base()
        {
            return;
        }
    }
}
