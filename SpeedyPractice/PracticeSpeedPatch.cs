using HMUI;
using UnityEngine;
using HarmonyLib;
using System;

namespace SpeedyPractice {
	[HarmonyPatch(typeof(PracticeViewController), "DidActivate")]
	static class PracticeSpeedPatch {
		static void Postfix(bool firstActivation, PercentSlider ____speedSlider) {
			if(!firstActivation)
				return;

			int minSpeed = PluginConfig.instance.minSpeed;
			int maxSpeed = PluginConfig.instance.maxSpeed;
			int stepSize = Math.Max(1, PluginConfig.instance.stepSize);

			maxSpeed -= (maxSpeed - minSpeed) % stepSize;

			____speedSlider.minValue = minSpeed / 100f;
			____speedSlider.maxValue = maxSpeed / 100f;
			____speedSlider.numberOfSteps = (maxSpeed - minSpeed) / stepSize + 1;

			____speedSlider.value = Math.Max(____speedSlider.minValue, 1);
		}
	}
}