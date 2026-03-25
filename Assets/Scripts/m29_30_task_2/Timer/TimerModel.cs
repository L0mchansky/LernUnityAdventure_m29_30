using System;
using System.Collections;
using UnityEngine;

namespace m29_30_task_2
{
    public class TimerModel : IReadOnlyTimer
    {
        private ReactiveVariable<float> _remainingTime;
        private float _fullTime;

        private Coroutine _runCoroutine;
        private MonoBehaviour _runner;

        public TimerModel(float fullTime, MonoBehaviour runner)
        {
            _fullTime = fullTime;
            _remainingTime = new ReactiveVariable<float>(fullTime);
            _runner = runner;
        }

        public bool IsRunning => _runCoroutine != null;
        public IReadOnlyVariable<float> RemainingTime => _remainingTime;
        public float FullTime => _fullTime;

        public void Tick(float deltaTime)
        {
            if (_runCoroutine == null) return;

            _remainingTime.Value = _remainingTime.Value - deltaTime;

            if (_remainingTime.Value <= 0)
            {
                _remainingTime.Value = 0;
                Stop();
            }
        }

        public void Start()
        {
            if (IsRunning == false)
                _runCoroutine = _runner.StartCoroutine(Run());
        }

        public void Stop()
        {
            if (IsRunning)
            {
                _runner.StopCoroutine(_runCoroutine);
                _runCoroutine = null;
            }  
        }

        public void Restart()
        {
            if (IsRunning)
            {
                _runner.StopCoroutine(_runCoroutine);
                _runCoroutine = null;
            }

            _remainingTime.Value = _fullTime;
        }

        public IEnumerator Run()
        {
            while (true)
            {
                Tick(Time.deltaTime);
                yield return null;
            }
        }
    }
}