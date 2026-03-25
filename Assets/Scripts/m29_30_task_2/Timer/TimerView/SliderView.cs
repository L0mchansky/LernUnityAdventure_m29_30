using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace m29_30_task_2
{
    public class SliderView : TimerView
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private TMP_Text _timerText;

        protected override void ViewRender()
        {
            FillTimerText();
            float normalize = NewTime / Timer.FullTime;
            _slider.value = normalize;
        }

        protected override void FillTimerText()
        {
            _timerText.text = $"{Math.Round(NewTime, 1)} / {Timer.FullTime}";
        }
    }
}