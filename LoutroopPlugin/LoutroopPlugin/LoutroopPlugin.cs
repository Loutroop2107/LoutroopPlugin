using System;
using System.IO;
using Harmony;
using MEC;
using EXILED;
using EXILED.Extensions;

namespace LoutroopPlugin
{
	public class LoutroopPlugin : Plugin
	{
		public override string getName { get; } = "LoutroopPlugin";
		public static readonly string harmonyId = "cn.Loutroop2107.LoutroopPlugin";
		public static readonly string Version = "2.0.1";
		public static readonly string TargetVersion = "1.10.6";
		public static readonly string PlayersDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Plugins", "LoutroopPlugin");
		public Random Gen = new Random();
		public static HarmonyInstance harmonyInstance { private set; get; }
		public static int harmonyCounter;
		private bool enabled;

		private EventHandlers EventHandlers;
		public HarmonyInstance harmony;

		public override void OnEnable()
		{
			enabled = Config.GetBool("LoutroopPlugin_enabled", true);

			if (!enabled) return;
			harmonyCounter++;
			harmonyInstance = HarmonyInstance.Create($"Loutroop.LoutroopPlugin{harmonyCounter}");
			harmonyInstance.PatchAll();
			EventHandlers = new EventHandlers(this);
			Events.RoundStartEvent += EventHandlers.OnRoundStart;
			Events.RoundEndEvent += EventHandlers.OnRoundEnd;
			Events.RoundRestartEvent += EventHandlers.OnRoundRestart;
			Events.ShootEvent += EventHandlers.OnShoot;
			Events.PlayerLeaveEvent += EventHandlers.OnPlayerLeave;
			Events.Scp106ContainEvent += EventHandlers.OnContain106;
			Events.Scp079LvlGainEvent += EventHandlers.On079LvlGain;
			Events.PlayerDeathEvent += EventHandlers.OnPlayerDie;
			Events.SetClassEvent += EventHandlers.OnSetRole;
			Events.CheckEscapeEvent += EventHandlers.OnCheckEscape;
			Events.TeamRespawnEvent += EventHandlers.OnTeamRespawn;
			Events.SpawnRagdollEvent += EventHandlers.OnSpawnRagdoll;
			Events.TriggerTeslaEvent += EventHandlers.OnTriggerTesla;
			Events.FemurEnterEvent += EventHandlers.OnFemurEnter;
			Events.Scp096EnrageEvent += EventHandlers.On096Enrage;
			Events.PocketDimDamageEvent += EventHandlers.OnPocketDimDamage;
			Events.AnnounceNtfEntranceEvent += EventHandlers.OnAnnounceNtfEntrance;
			Events.AnnounceDecontaminationEvent += EventHandlers.OnAnnounceDecontamination;
			Events.UsedMedicalItemEvent += EventHandlers.OnUseMedicalItem;
			Events.PickupItemEvent += EventHandlers.OnPickupItem;
			Events.Scp106TeleportEvent += EventHandlers.OnTeleport106;
		}

		public override void OnDisable()
		{
			Events.RoundStartEvent -= EventHandlers.OnRoundStart;
			Events.RoundEndEvent -= EventHandlers.OnRoundEnd;
			Events.RoundRestartEvent -= EventHandlers.OnRoundRestart;
			Events.ShootEvent -= EventHandlers.OnShoot;
			Events.PlayerLeaveEvent -= EventHandlers.OnPlayerLeave;
			Events.Scp106ContainEvent -= EventHandlers.OnContain106;
			Events.Scp079LvlGainEvent -= EventHandlers.On079LvlGain;
			Events.PlayerDeathEvent -= EventHandlers.OnPlayerDie;
			Events.SetClassEvent -= EventHandlers.OnSetRole;
			Events.CheckEscapeEvent -= EventHandlers.OnCheckEscape;
			Events.TeamRespawnEvent -= EventHandlers.OnTeamRespawn;
			Events.SpawnRagdollEvent -= EventHandlers.OnSpawnRagdoll;
			Events.TriggerTeslaEvent -= EventHandlers.OnTriggerTesla;
			Events.FemurEnterEvent -= EventHandlers.OnFemurEnter;
			Events.Scp096EnrageEvent -= EventHandlers.On096Enrage;
			Events.PocketDimDamageEvent -= EventHandlers.OnPocketDimDamage;
			Events.AnnounceNtfEntranceEvent -= EventHandlers.OnAnnounceNtfEntrance;
			Events.AnnounceDecontaminationEvent -= EventHandlers.OnAnnounceDecontamination;
			Events.UsedMedicalItemEvent -= EventHandlers.OnUseMedicalItem;
			Events.PickupItemEvent -= EventHandlers.OnPickupItem;
			Events.Scp106TeleportEvent -= EventHandlers.OnTeleport106;
			EventHandlers = null;
		}

		public override void OnReload()
		{
		}
	}
}