using System;
using UnityEngine;

namespace ExampleDowncast
{
    public class Bank : MonoBehaviour, IGridObject, IIncomeDealer
    {
        public event Action<float> IncomeTrigger;

        private const float Second = 1;
        private float _incomePerSecond;

        private float _time;

        private bool _isActive;

        public void Initialize(float incomePerSecond)
        {
            _incomePerSecond = incomePerSecond;
        }

        private void Update()
        {
            if (_isActive == false)
                return;

            _time += Time.deltaTime;

            if (_time > Second)
            {
                IncomeTrigger?.Invoke(_incomePerSecond);
                _time = 0;
            }
        }

        public void BindTo(Vector3 worldPosition)
        {
            transform.position = worldPosition;
            _isActive = true;
        }
    }
}
