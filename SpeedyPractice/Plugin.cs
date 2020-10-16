using IPA;
using IPA.Config;
using IPA.Config.Stores;
using IPA.Logging;
using UnityEngine;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;

namespace SpeedyPractice {
	
	[Plugin(RuntimeOptions.SingleStartInit)]
	public class Plugin {
		
		internal static Plugin instance { get; private set; }
		internal static IPALogger log { get; private set; }
		
		[Init]
		public Plugin(IPALogger logger, Config config) {
			
			instance = this;
			log = logger;
			
			PluginConfig.instance = config.Generated<PluginConfig>();
			
		}
		
		[OnEnable]
		public void OnEnable() {
			
			SceneManager.activeSceneChanged += OnSceneChanged;
			
		}
		
		[OnDisable]
		public void OnDisable() {
			
			SceneManager.activeSceneChanged -= OnSceneChanged;
			
		}
		
		public void OnSceneChanged(Scene prevScene, Scene nextScene) {
			
			if (nextScene.name == "MenuViewControllers") {
				
				new GameObject("SpeedyLight").AddComponent<SliderController>();
				
			}
			
		}
		
	}
	
}