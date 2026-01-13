using Terraria;
using Terraria.Audio;
using Terraria.ModLoader;

namespace Sounds_SakurabaEma.Utils
{
    internal static class AssetsUtils
    {
        /// <summary>
        /// 获取Sound
        /// </summary>
        /// <param name="fileName">路径为Assets/Sounds/*</param>
        /// <param name="numVariants">随机选取的目标数量</param>
        /// <param name="volume">音量</param>
        /// <param name="pitch">音调</param>
        /// <param name="pitchVariance">音调随机浮动</param>
        /// <param name="maxInstances">叠加播放上限</param>
        /// <param name="soundLimitBehavior">到达上限之后的操作</param>
        /// <param name="type">声音类型（音乐/音效/环境）</param>
        public static SoundStyle GetSoundStyle(string fileName, int numVariants = 1, float volume = 1f, float pitch = 0, float pitchVariance = 0, int maxInstances = 1, SoundLimitBehavior soundLimitBehavior = SoundLimitBehavior.IgnoreNew, SoundType type = SoundType.Sound)
        {
            return new SoundStyle($"Sounds_SakurabaEma/Assets/Sounds/{fileName}", numVariants) with
            {
                Volume = volume,
                Pitch = pitch,
                PitchVariance = pitchVariance,
                MaxInstances = maxInstances,
                SoundLimitBehavior = soundLimitBehavior,
                Type = type
            };
        }
    }
}
