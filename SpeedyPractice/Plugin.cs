using IPA;
using IPALogger = IPA.Logging.Logger;

namespace SpeedyPractice {
	
	[Plugin(RuntimeOptions.SingleStartInit)]
	public class Plugin {
		
		internal static Plugin instance { get; private set; }
		internal static IPALogger log { get; private set; }
		
		[Init]
		public Plugin(IPALogger logger) {
			
			instance = this;
			log = logger;
			
		}
		
	}
	
}