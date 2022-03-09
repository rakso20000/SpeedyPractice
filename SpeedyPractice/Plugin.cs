using IPA;
using IPA.Config;
using IPA.Config.Stores;
using IPALogger = IPA.Logging.Logger;
using HarmonyLib;
using System.Reflection;

namespace SpeedyPractice {
	[Plugin(RuntimeOptions.DynamicInit)]
	public class Plugin {
		internal static Plugin instance { get; private set; }
		internal static IPALogger log { get; private set; }
		internal static Harmony harmony { get; private set; }

		[Init]
		public Plugin(IPALogger logger, Config config) {
			instance = this;
			log = logger;
			
			PluginConfig.instance = config.Generated<PluginConfig>();

			harmony = new Harmony("rakso20000.BeatSaber.SpeedyPractice");
		}
		
		[OnEnable]
		public void OnEnable() {
			harmony.PatchAll(Assembly.GetExecutingAssembly());
		}
		
		[OnDisable]
		public void OnDisable() {
			harmony.UnpatchSelf();
		}
		
	}
	
}