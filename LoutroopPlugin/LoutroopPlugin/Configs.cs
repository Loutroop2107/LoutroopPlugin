using System;
using System.Collections.Generic;
using System.Reflection;
using EXILED;

namespace LoutroopPlugin
{
    internal static class Configs//大多参考于SanyaPlugin
    {
        //停电设定
        internal static float cpuppf;
        internal static float Enragepf;

        internal static string RoundEndMessage;
        internal static uint RoundEndMessagebctime;
        internal static uint PlayerJoinMessagebctime;
        internal static string ComLvlGainMessage;
        internal static uint ComLvlGainMessagebctime;
        internal static string ComLvlGainCassieMessage;
        internal static string SBEnrageCassieMessage;
        internal static string ContainMessage;
        internal static uint ContainMessagebctime;
        internal static string ClassDEscapeCassieMessage;
        internal static string ScientistEscapeCassieMessage;
        internal static string RoundEndCassieMessage;
        internal static string FemurEnterMessage;
        internal static uint FemurEnterMessagebctime;
        internal static string FemurEnterCassieMessage;
        internal static string MTFRespawnSCPMessage;
        internal static uint MTFRespawnSCPMessagebctime;
        internal static string MTFRespawnNOSCPMessage;
        internal static uint MTFRespawnNOSCPMessagebctime;
        internal static string ChaosEnterMessage;
        internal static string ChaosEnterCassieMessage;
        internal static uint ChaosEnterMessagebctime;
        internal static string AnnounceDecontaminationMessage;
        internal static uint AnnounceDecontaminationMessagebctime;
        internal static uint PickupMHIDmsgbctime;
        //SCP-181参数
        internal static string LuckyBoySpawnmsg;
        internal static uint LuckyBoySpawnmsgbctime;
        internal static string LuckyBoyDeathCassiemsg;
        internal static uint LuckyBoyDeathmsgbctime;
        internal static string LuckyBoySafeAmountPlayermsg;
        internal static uint LuckyBoySafeAmountPlayermsgbctime;
        internal static string LuckyBoySafeAmountAttackermsg;
        internal static uint LuckyBoySafeAmountAttackermsgbctime;
        internal static string ChaosCommanderSpawnmsg;
        internal static uint ChaosCommanderSpawnmsgbctime;
        internal static string SCP999Spawnmsg;
        internal static uint SCP999Spawnmsgbctime;
        internal static string SCP550Spawnmsg;
        internal static uint SCP550Spawnmsgbctime;
        internal static List<int> ChaosCommanderSpawnItem;
        internal static List<int> SCP181SpawnItem;
        internal static List<int> SCP999SpawnItem;
        internal static List<int> SCP550SpawnItem;
        internal static string SCP999DeathCassieMessage;
        internal static uint SCP999DeathMessagebctime;
        internal static string SCP550DeathCassieMessage;
        internal static uint SCP550DeathMessagebctime;
        internal static string DropCoinRandomEventMessage1;
        internal static string DropCoinRandomEventMessage2;
        internal static string DropCoinRandomEventMessage3;
        internal static string DropCoinRandomEventMessage4;
        internal static string BIGDOGSpawnMessage;
        internal static uint BiGDOGSpawnMessagebctime;
        internal static bool SCP181Switch;
        internal static bool ChaosCommanderSwitch;
        internal static bool SCP550Switch;
        internal static bool SCP999Switch;
        internal static bool SCP682Switch;

        internal static void ReloadConfig()
        {
            //停电设定
            cpuppf = Plugin.Config.GetFloat("cpuppf", 60f);
            Enragepf = Plugin.Config.GetFloat("eepf", 20f);

            RoundEndMessage = Plugin.Config.GetString("RoundEndMessage", "<color=red>[系统消息]</color>\n回合已结束，感谢您在本服游玩！友伤已开启");
            RoundEndMessagebctime = Plugin.Config.GetUInt("RoundEndMessage", 5);
            PlayerJoinMessagebctime = Plugin.Config.GetUInt("PlayerJoinMessagebctime", 3);
            ComLvlGainMessagebctime = Plugin.Config.GetUInt("ComLvlGainMessagebctime", 3);
            ComLvlGainMessage = Plugin.Config.GetString("ComLvlGainMessage", "<color=red>[系统消息]</color>\nSCP-079升级了！");
            ComLvlGainCassieMessage = Plugin.Config.GetString("ComLvlGainCassieMessage", "SCP 0 7 9 LVL GAIN HEAVY .g3 .g4 UNKNOWN MALFUNCTION DETECTED");
            SBEnrageCassieMessage = Plugin.Config.GetString("SBEnrageCassieMessage", "HEAVY.g3.g3.g3.g3.g3 UNKNOWN MALFUNCTION DETECTED");
            ContainMessage = Plugin.Config.GetString("ContainMessage", "<color=red>[系统消息]</color>\n《(因大腿骨粉碎机而痛苦大叫)》\n为什么? 为什么!\n呜呜呜呜呜呜呜");
            ContainMessagebctime = Plugin.Config.GetUInt("ContainMessagebctime", 10);
            ClassDEscapeCassieMessage = Plugin.Config.GetString("ClassDEscapeCassieMessage", ".g3 .g4 HAS A CLASS D PERSONNEL  ESCAPE");
            ScientistEscapeCassieMessage = Plugin.Config.GetString("ScientistEscapeCassieMessage", ".g3 .g2 HAS A SCIENTIST ESCAPE");
            RoundEndCassieMessage = Plugin.Config.GetString("RoundEndCassieMessage", ".g1 ROUND IS END THANK YOU PLAY THIS SERVER FRIENDLY FIRE IS OPEN");
            FemurEnterMessage = Plugin.Config.GetString("FemurEnterMessage", "<color=red>[系统消息]</color>大腿粉碎机准备完成！");
            FemurEnterCassieMessage = Plugin.Config.GetString("FemurEnterCassieMessage", "FEMUR ENTER IS READY .g3");
            FemurEnterMessagebctime = Plugin.Config.GetUInt("FemurEnterMessagebcime", 3);
            MTFRespawnSCPMessage = Plugin.Config.GetString("MTFRespawnSCPMessage", "<color=red>[系统消息]</color>\n机动特遣队伊普希伦-11[{0}]到达了设施。剩下的全体工作人员推荐在机动部队到达你的地方之前，继续执行[标准避难协议]。\n[{1}]对象未被重新收容。");
            MTFRespawnSCPMessagebctime = Plugin.Config.GetUInt("MTFRespawnSCPMessagebctime", 10);
            MTFRespawnNOSCPMessage = Plugin.Config.GetString("MTFRespawnNOSCPMessage", "<color=red>[系统消息]</color>\n机动特遣队伊普希伦-11[{0}]到达了设施。剩下的全体工作人员推荐在机动部队到达你的地方之前，继续执行[标准避难协议]。\n设施内存在重大威胁，请注意。");
            MTFRespawnNOSCPMessagebctime = Plugin.Config.GetUInt("MTFRespawnNoSCPMessagebcime", 10);
            ChaosEnterMessage = Plugin.Config.GetString("ChaosEnterMessage", "<color=red>[系统消息]</color>\n警告，未知人员闯入设施");
            ChaosEnterMessagebctime = Plugin.Config.GetUInt("ChaosEnterMessagebctime", 10);
            ChaosEnterCassieMessage = Plugin.Config.GetString("ChaosEnterCassieMessage", "WARNING UNKNOWN PERSONNEL BREAK INTO THE FACILITY.g4 .g1 .g2 .g3");
            AnnounceDecontaminationMessage = Plugin.Config.GetString(" AnnounceDecontaminationMessage", "<color=red>[系统消息]</color>\n警告，轻收容区的[净化]协议在{0}分钟内实施。");
            AnnounceDecontaminationMessagebctime = Plugin.Config.GetUInt("AnnounceDecontaminationMessagebctime", 10);
            PickupMHIDmsgbctime = Plugin.Config.GetUInt("PickupMIDmsgbctime", 5);
            LuckyBoySpawnmsg = Plugin.Config.GetString("LuckyBoySpawnmsg", "<color=red>[系统消息]</color>\n你是SCP-181，你有几率空手开门和抵挡伤害");
            LuckyBoySpawnmsgbctime = Plugin.Config.GetUInt("LuckyBoySpawnmsgbctime", 10);
            LuckyBoyDeathCassiemsg = Plugin.Config.GetString("LuckyBoyDeathCassiemsg", "SCP 181 CONTAINED SUCCESSFULLY");
            LuckyBoyDeathmsgbctime = Plugin.Config.GetUInt("LuckyBoyDeathmsgbctime", 10);
            LuckyBoySafeAmountAttackermsg = Plugin.Config.GetString("LuckyBoySafeAmountAttackermsg", "SCP-181抵挡了你的攻击");
            LuckyBoySafeAmountAttackermsgbctime = Plugin.Config.GetUInt("LuckyBoySafeAmountAttackermsgbctime", 3);
            LuckyBoySafeAmountPlayermsg = Plugin.Config.GetString("LuckyBoySafeAmountPlayermsg", "你抵挡了一次攻击");
            LuckyBoySafeAmountPlayermsgbctime = Plugin.Config.GetUInt("LuckyBoySafeAmountPlayermsgbctime", 3);
            ChaosCommanderSpawnmsg = Plugin.Config.GetString("ChaosCommanderSpawnMessage", "<color=red>[系统消息]</color>你是混沌指挥官，你的伤害很强，血量更多，珍惜这个身份！");
            ChaosCommanderSpawnmsgbctime = Plugin.Config.GetUInt("ChaosCommanderSpawnMessagebctime", 10);
            ChaosCommanderSpawnItem = Plugin.Config.GetIntList("ChaosCommanderSpawnItem");
            SCP999Spawnmsg = Plugin.Config.GetString("SCP999Spawnmsg", "<color=red>[系统消息]</color>\n你是SCP-999，你可以为其他玩家加血");
            SCP999Spawnmsgbctime = Plugin.Config.GetUInt("SCP999Spawnmsgbctime", 10);
            SCP550Spawnmsg = Plugin.Config.GetString("SCP550Spawnmsg", "<color=red>[系统消息]</color>\n你是SCP-550，你的阵营为SCP，当你攻击别人时可以为自己加打出去的攻击的四分之一血");
            SCP550Spawnmsgbctime = Plugin.Config.GetUInt("SCP550Spawnmsgbctime", 10);
            SCP999DeathCassieMessage = Plugin.Config.GetString("SCP999DeathCassieMessage", "SCP 9 9 9 CONTAINED SUCCESSFULLY");
            SCP999DeathMessagebctime = Plugin.Config.GetUInt("SCP999DeathMessagebctime", 10);
            SCP550DeathCassieMessage = Plugin.Config.GetString("SCP550DeathCassieMessage", "SCP 5 5 0 CONTAINED SUCCESSFULLY");
            SCP550DeathMessagebctime = Plugin.Config.GetUInt("SCP550DeathMessagebctime", 10);
            BIGDOGSpawnMessage = Plugin.Config.GetString("BigDogSpawnMessage", "<color=red>[系统消息]</color>你是SCP-682，你是一种无懈可击的生物！");
            BiGDOGSpawnMessagebctime = Plugin.Config.GetUInt("BigDogSpawnMessage", 5);
            SCP181Switch = Plugin.Config.GetBool("SCP181Switch", true);
            ChaosCommanderSwitch = Plugin.Config.GetBool("ChaosSwitch", true);
            SCP999Switch = Plugin.Config.GetBool("SCP999Switch", true);
            SCP550Switch = Plugin.Config.GetBool("SCP550Switch", true);
            SCP682Switch = Plugin.Config.GetBool("SCP682Switch", true);

            if (ChaosCommanderSpawnItem == null || ChaosCommanderSpawnItem.Count == 0)
            {
                ChaosCommanderSpawnItem = new List<int>() { 11, 17, 30, 25, 24 };
            }
            SCP181SpawnItem = Plugin.Config.GetIntList("SCP181SpawnItem");
            if (SCP181SpawnItem == null || SCP181SpawnItem.Count == 0)
            {
                SCP181SpawnItem = new List<int>() { 30 };
            }
            SCP999SpawnItem = Plugin.Config.GetIntList("SCP999SpawnItem");
            if (SCP999SpawnItem == null || SCP999SpawnItem.Count == 0)
            {
                SCP999SpawnItem = new List<int>() { 30, 14, 7 };
            }
            SCP550SpawnItem = Plugin.Config.GetIntList("SCP550SpawnItem");
            if (SCP550SpawnItem == null || SCP550SpawnItem.Count == 0)
            {
                SCP550SpawnItem = new List<int>() { 20, 14, 7 };
            }

            Log.Info("[配置]加载完毕！");
        }

        internal static string GetConfigs()
        {
            string returned = "\n";

            FieldInfo[] infoArray = typeof(Configs).GetFields(BindingFlags.Static | BindingFlags.NonPublic);

            foreach (FieldInfo info in infoArray)
            {
                returned += $"{info.Name}: {info.GetValue(null)}\n";
            }

            return returned;
        }

    }
}
