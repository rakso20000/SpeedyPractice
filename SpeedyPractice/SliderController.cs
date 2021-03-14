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
			int stepSize = PluginConfig.instance.stepSize;
			
			if (stepSize <= 0)
				stepSize = 1;
			
			maxSpeed -= (maxSpeed - minSpeed) % stepSize;
			
			slider.minValue = minSpeed / 100f;
			slider.maxValue = maxSpeed / 100f;
			slider.numberOfSteps = (maxSpeed - minSpeed) / stepSize + 1;
			
			Destroy(this);
			
		}
		
	}
	
}