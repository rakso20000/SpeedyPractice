using HMUI;
using UnityEngine;
using Zenject;

namespace SpeedyPractice {
	
	public class SliderController : MonoBehaviour {
		
		private PracticeViewController practiceView;
		
		[Inject]
		public void Inject(PracticeViewController practiceView) {
			
			this.practiceView = practiceView;
			
		}
		
		public void Start() {
			
			if (practiceView == null)
				return;
			
			PercentSlider slider = Helper.GetValue<PercentSlider>(practiceView, "_speedSlider");
			
			int maxSpeed = PluginConfig.instance.maxSpeed;
			
			maxSpeed = maxSpeed - (maxSpeed % 5);
			
			slider.maxValue = maxSpeed / 100f;
			slider.numberOfSteps = maxSpeed / 5 - 9;
			
			
		}
		
	}
	
}