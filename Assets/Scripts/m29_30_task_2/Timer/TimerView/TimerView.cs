using UnityEngine;

namespace m29_30_task_2
{
    public abstract class TimerView: MonoBehaviour
    {
        private IReadOnlyTimer _timer;
        protected IReadOnlyTimer Timer => _timer;
        protected float OldTime { get; private set; }
        protected float NewTime { get; private set; }

        private void Start()
        {
            FillTimerText();
        }

        public void Initialize(IReadOnlyTimer timer)
        {
            _timer = timer;

            _timer.RemainingTime.Changed += OnChanged;
        }

        private void OnDestroy()
        {
            _timer.RemainingTime.Changed -= OnChanged;
        }

        private void OnChanged(float oldTime, float newTime)
        {
            OldTime = oldTime;
            NewTime = newTime;
            ViewRender();
        }

        protected abstract void FillTimerText();
        protected abstract void ViewRender();
    }
}