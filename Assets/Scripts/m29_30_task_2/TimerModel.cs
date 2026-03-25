using System;
using System.Collections;
using UnityEngine;

namespace m29_30_task_2
{
    public class TimerModel
    {
        public event Action Ticked;
        public event Action Reset;

        private float _remainingTime;
        private float _fullTime;

        private Coroutine _runCoroutine;
        private MonoBehaviour _runner;

        public TimerModel(float fullTime, MonoBehaviour runner)
        {
            _fullTime = fullTime;
            _remainingTime = fullTime;
            _runner = runner;
        }

        public bool IsRunning => _runCoroutine != null;
        public float RemainingTime => _remainingTime;
        public float FullTime => _fullTime;

        public void Tick(float deltaTime)
        {
            if (_runCoroutine == null) return;

            _remainingTime = _remainingTime - deltaTime;

            if (_remainingTime <= 0)
            {
                _remainingTime = 0;
                Stop();
            }

            Ticked?.Invoke();
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
                _remainingTime = _fullTime;
                Reset?.Invoke();
            }
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