using System.Collections.Generic;
using Terraria.Audio;
using Terraria.ModLoader;
using static Sounds_SakurabaEma.Utils.AssetsUtils;

namespace Sounds_SakurabaEma.Assets
{
    internal class SoundLoader : ModSystem
    {
        public static SoundStyle HitSound;
        public static SoundStyle HitSound_Kiang;
        public static List<SoundStyle> KillSound;
        public static SoundStyle KillSound_2;

        public override void Load()
        {
            HitSound = GetSoundStyle("hit_", 5, soundLimitBehavior: SoundLimitBehavior.ReplaceOldest);
            HitSound_Kiang = GetSoundStyle("hit_5", 1, soundLimitBehavior: SoundLimitBehavior.ReplaceOldest);
            KillSound = [];
            for (int i = 1; i <= Sounds_SakurabaEma.KillSoundCount; i++)
            {
                KillSound.Add(GetSoundStyle($"Kill/{i}", 1));
            }
            KillSound_2 = GetSoundStyle("kill_", 4, soundLimitBehavior: SoundLimitBehavior.ReplaceOldest);
        }
    }
}
