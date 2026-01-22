using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace Sounds_SakurabaEma.Common.Configs
{
    internal class CommonConfig : ModConfig
    {
        public static CommonConfig Instance;

        public override ConfigScope Mode => ConfigScope.ClientSide;

        public override void OnLoaded() => Instance = this;

        [DefaultValue("false")]
        public bool IMaTV;

        [DefaultValue("false")]
        public bool UseKiangHitSound;
    }
}
