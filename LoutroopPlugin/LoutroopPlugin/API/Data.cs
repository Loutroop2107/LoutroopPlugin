using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoutroopPlugin.API
{
    public static class Data
    {
		public static ReferenceHub GetSCP181()
		{
			return EventHandlers.SCP181;
		}

		public static ReferenceHub GetChaosCommander()
		{
			return EventHandlers.ChaosCommander;
		}

		public static ReferenceHub GetSCP550()
		{
			return EventHandlers.SCP550;
		}

		public static ReferenceHub GetSCP999()
		{
			return EventHandlers.SCP999;
		}

		public static void SpawnPluginRole181(ReferenceHub player)
		{
			EventHandlers.SpawnSCP181(player);
		}

		public static void SpawnPluginRoleChaos(ReferenceHub player)
		{
			EventHandlers.SpawnChaosCommander(player);
		}

		public static void SpawnPluginRole550(ReferenceHub player)
		{
			EventHandlers.SpawnSCP550(player);
		}

		public static void SpawnPluginRole999(ReferenceHub player)
		{
			EventHandlers.SpawnSCP999(player);
		}

	}
}
