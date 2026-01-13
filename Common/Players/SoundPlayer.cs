using Sounds_SakurabaEma.Assets;
using Sounds_SakurabaEma.Common.Configs;
using System;
using System.Reflection;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Sounds_SakurabaEma.Common.Players
{
    internal class SoundPlayer : ModPlayer
    {
        #region hit

        public override void OnHitByNPC(NPC npc, Player.HurtInfo hurtInfo)
        {
            hurtInfo.SoundDisabled = true;
            SoundEngine.PlaySound(SoundLoader.HitSound, Player.position);
        }

        public override void OnHitByProjectile(Projectile proj, Player.HurtInfo hurtInfo)
        {
            hurtInfo.SoundDisabled = true;
            SoundEngine.PlaySound(SoundLoader.HitSound, Player.position);
        }

        public override void ModifyHitByNPC(NPC npc, ref Player.HurtModifiers modifiers)
        {
            modifiers.DisableSound();
        }

        public override void ModifyHitByProjectile(Projectile proj, ref Player.HurtModifiers modifiers)
        {
            modifiers.DisableSound();
        }

        #endregion

        #region death

        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genDust, ref PlayerDeathReason damageSource)
        {
            // 禁用原版死亡音效
            playSound = false;
            return true;
        }

        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            if (Player.whoAmI == Main.myPlayer)
            {
                if (CommonConfig.Instance.IMaTV)
                {
                    SoundEngine.PlaySound(SoundLoader.KillSound_2, Player.position);
                }
                else
                {
                    Random random = new();
                    int index = random.Next(SoundLoader.KillSound.Count);
                    {
                        // 播放自定义死亡音效
                        SoundEngine.PlaySound(SoundLoader.KillSound[index], Player.position);
                        // 设置自定义死亡原因文本
                        damageSource.CustomReason = NetworkText.FromKey($"Mods.Sounds_SakurabaEma.DeathReason.index{index + 1}");
                    }
                }
            }
        }

        #endregion
    }
}
