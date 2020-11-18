using IPA.Config.Stores;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace SpeedyPractice {
	
	internal class PluginConfig {
		
		public static PluginConfig instance { get; set; }
		
		public virtual int maxSpeed { get; set; } = 300;
		
	}
	
}