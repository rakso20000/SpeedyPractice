using IPA.Config.Stores;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace SpeedyPractice {
	
	internal class PluginConfig {
		
		public static PluginConfig instance { get; set; }
		
		public virtual int minSpeed { get; set; } = 50;
		public virtual int maxSpeed { get; set; } = 300;
		public virtual int stepSize { get; set; } = 5;
		
	}
	
}