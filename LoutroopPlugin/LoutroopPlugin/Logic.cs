using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXILED;
using EXILED.Extensions;
using MEC;

namespace LoutroopPlugin
{
    partial class EventHandlers
    {
        
        private static void KillSCP181(bool setRank = true)
        {
            if (setRank)
            {
                SCP181.SetRank("", "default");
                if (hasTag) SCP181.RefreshTag();
                if (isHidden) SCP181.HideTag();
            }
            SCP181 = null;
        }

        private static void KillChaosCommander(bool setRank = true)
        {
            if (setRank)
            {
                ChaosCommander.SetRank("", "default");
                if (hasTag) ChaosCommander.RefreshTag();
                if (isHidden) ChaosCommander.HideTag();
            }
            ChaosCommander = null;
        }
        
        private static void KillSCP999(bool setRank = true)
        {
            if (setRank)
            {
                SCP999.SetRank("", "default");
                if (hasTag) SCP999.RefreshTag();
                if (isHidden) SCP999.HideTag();
            }
            SCP999 = null;
        }

        private static void KillSCP550(bool setRank = true)
        {
            if (setRank)
            {
                SCP550.SetRank("", "default");
                if (hasTag) SCP550.RefreshTag();
                if (isHidden) SCP550.HideTag();
            }
            SCP550 = null;
        }

        private static void KillSCP682(bool setRank = true)
        {
            if (setRank)
            {
                SCP682.SetRank("", "default");
                if (hasTag) SCP682.RefreshTag();
                if (isHidden) SCP682.HideTag();
            }
            SCP682 = null;
        }

        public static void SpawnSCP181(ReferenceHub LuckyBoy)
        {
            LuckyBoy.characterClassManager.SetClassID(RoleType.ClassD);
            LuckyBoy.Broadcast(Configs.LuckyBoySpawnmsg, Configs.LuckyBoySpawnmsgbctime);
            hasTag = !string.IsNullOrEmpty(LuckyBoy.serverRoles.NetworkMyText);
            isHidden = !string.IsNullOrEmpty(LuckyBoy.serverRoles.HiddenBadge);
            if (isHidden) LuckyBoy.RefreshTag();
            LuckyBoy.inventory.items.ToList().Clear();
            for (int i = 0; i < Configs.SCP181SpawnItem.Count; i++)
            {
                LuckyBoy.inventory.AddNewItem((ItemType)Configs.SCP181SpawnItem[i]);
            }
            LuckyBoy.SetRank("SCP-181", "orange");
            SCP181 = LuckyBoy;
        }

        public static void SpawnChaosCommander(ReferenceHub Chaosss)
        {
            Chaosss.characterClassManager.SetClassID(RoleType.ChaosInsurgency);
            Chaosss.Broadcast(Configs.ChaosCommanderSpawnmsg, Configs.ChaosCommanderSpawnmsgbctime);
            hasTag = !string.IsNullOrEmpty(Chaosss.serverRoles.NetworkMyText);
            isHidden = !string.IsNullOrEmpty(Chaosss.serverRoles.HiddenBadge);
            if (isHidden) Chaosss.RefreshTag();
            Chaosss.SetHealth(300f);
            Chaosss.inventory.items.ToList().Clear();
            for (int i = 0; i < Configs.ChaosCommanderSpawnItem.Count; i++)
            {
                Chaosss.inventory.AddNewItem((ItemType)Configs.ChaosCommanderSpawnItem[i]);
            }
            Chaosss.SetRank("Chaos Commander", "green");
            ChaosCommander = Chaosss;
        }

        public static void SpawnSCP999(ReferenceHub TTM)
        {
            TTM.characterClassManager.SetClassID(RoleType.Tutorial);
            TTM.Broadcast(Configs.SCP999Spawnmsg, Configs.SCP999Spawnmsgbctime);
            hasTag = !string.IsNullOrEmpty(TTM.serverRoles.NetworkMyText);
            isHidden = !string.IsNullOrEmpty(TTM.serverRoles.HiddenBadge);
            if (isHidden) TTM.RefreshTag();
            Timing.RunCoroutine(EventHandlers.DelayAction(0.5f, () => TTM.plyMovementSync.OverridePosition(Map.GetRandomSpawnPoint(RoleType.FacilityGuard), 0f)));
            TTM.SetHealth(5000f);
            TTM.inventory.items.ToList().Clear();
            for (int i = 0; i < Configs.SCP999SpawnItem.Count; i++)
            {
                TTM.inventory.AddNewItem((ItemType)Configs.SCP999SpawnItem[i]);
            }
            TTM.SetRank("SCP-999", "pink");
            SCP999 = TTM;
        }

        public static void SpawnSCP550(ReferenceHub Ghoul)
        {
            Ghoul.characterClassManager.SetClassID(RoleType.Tutorial);
            Ghoul.Broadcast(Configs.SCP999Spawnmsg, Configs.SCP999Spawnmsgbctime);
            hasTag = !string.IsNullOrEmpty(Ghoul.serverRoles.NetworkMyText);
            isHidden = !string.IsNullOrEmpty(Ghoul.serverRoles.HiddenBadge);
            if (isHidden) Ghoul.RefreshTag();
            Timing.RunCoroutine(EventHandlers.DelayAction(0.5f, () => Ghoul.plyMovementSync.OverridePosition(Map.GetRandomSpawnPoint(RoleType.Scp049), 0f)));
            Ghoul.SetHealth(200f);
            Ghoul.inventory.items.ToList().Clear();
            for (int i = 0; i < Configs.SCP550SpawnItem.Count; i++)
            {
                Ghoul.inventory.AddNewItem((ItemType)Configs.SCP550SpawnItem[i]);
            }
            Ghoul.SetRank("SCP-550", "red");
            SCP550 = Ghoul;
        }

        public static void SpawnSCP682(ReferenceHub BigDog)
        {
            BigDog.characterClassManager.SetClassID(RoleType.Scp93953);
            BigDog.Broadcast(Configs.BIGDOGSpawnMessage, Configs.BiGDOGSpawnMessagebctime);
            hasTag = !string.IsNullOrEmpty(BigDog.serverRoles.NetworkMyText);
            isHidden = !string.IsNullOrEmpty(BigDog.serverRoles.HiddenBadge);
            BigDog.SetHealth(6000f);
            BigDog.SetRank("SCP-682", "red");
            SCP682 = BigDog;
        }

        public static void InfectPlayerOnRoundStart()
        {
            if (Configs.SCP181Switch == true)
            {
                List<ReferenceHub> pList = Player.GetHubs().Where(x => x.characterClassManager.CurClass == RoleType.ClassD && x.characterClassManager.UserId != null && x.characterClassManager.UserId != string.Empty).ToList();


                if (pList.Count > 3 && SCP181 == null)
                {
                    SpawnSCP181(pList[rand.Next(pList.Count)]);
                }

            }

            if (Configs.SCP999Switch == true)
            {
                List<ReferenceHub> pList = Player.GetHubs().Where(x => x.characterClassManager.CurClass == RoleType.Tutorial && x.characterClassManager.UserId != null && x.characterClassManager.UserId != string.Empty).ToList();


                if (pList.Count > 6 && SCP999 == null)
                {
                    SpawnSCP999(pList[rand.Next(pList.Count)]);
                }

            }

            if (Configs.SCP550Switch == true)
            {
                List<ReferenceHub> pList = Player.GetHubs().Where(x => x.characterClassManager.CurClass == RoleType.Tutorial && x.characterClassManager.UserId != null && x.characterClassManager.UserId != string.Empty).ToList();


                if (pList.Count > 10 && SCP550 == null)
                {
                    SpawnSCP550(pList[rand.Next(pList.Count)]);
                }

            }

            if (Configs.SCP682Switch == true)
            {
                List<ReferenceHub> pList = Player.GetHubs().Where(x => x.characterClassManager.CurClass == RoleType.Scp93953 && x.characterClassManager.UserId != null && x.characterClassManager.UserId != string.Empty).ToList();


                if (pList.Count > 20 && SCP682 == null)
                {
                    SpawnSCP682(pList[rand.Next(pList.Count)]);
                }

            }

        }

        public static void InfectPlayerOnTeamRespawn()
        {
            if (Configs.ChaosCommanderSwitch == true)
            {
                List<ReferenceHub> pList = Player.GetHubs().Where(x => x.characterClassManager.CurClass == RoleType.ChaosInsurgency && x.characterClassManager.UserId != null && x.characterClassManager.UserId != string.Empty).ToList();
                
                if (pList.Count > 9 && ChaosCommander == null)
                {
                    SpawnChaosCommander(pList[rand.Next(pList.Count)]);
                }
            }
        }

        public static IEnumerator<float> DelayAction(float delay, Action x)
        {
            yield return Timing.WaitForSeconds(delay);
            x();
        }

    }
}
