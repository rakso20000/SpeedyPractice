using HMUI;
using TwitchFX;
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
			
			PercentSlider slider = Helper.GetValue<PercentSlider>(practiceView, "_speedSlider");
			
			slider.maxValue = 2f;
			
		}
		
	}
	
}