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
			
			if (practiceView == null) {
				
				Destroy(this);
				
				return;
				
			}
			
			PercentSlider slider = Helper.GetValue<PercentSlider>(practiceView, "_speedSlider");
			
			int minSpeed = PluginConfig.instance.minSpeed;
			int maxSpeed = PluginConfig.instance.maxSpeed;
			
			minSpeed -= minSpeed % 5;
			maxSpeed -= maxSpeed % 5;
			
			slider.minValue = minSpeed / 100f;
			slider.maxValue = maxSpeed / 100f;
			slider.numberOfSteps = (maxSpeed - minSpeed) / 5 + 1;
			
			Destroy(this);
			
		}
		
	}
	
}