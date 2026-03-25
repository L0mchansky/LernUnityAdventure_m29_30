using TMPro;
using UnityEngine;

namespace m29_30_task_1 {
    public class WalletUIView : MonoBehaviour
    {
        [SerializeField] TMP_Text currencyUiValue;

        private Currency _currency;

        public void Initialize(Currency currency)
        {
            _currency = currency;

            _currency.Amount.Changed += OnChanged;
        }

        private void OnDestroy()
        {
            _currency.Amount.Changed -= OnChanged;
        }

        private void OnChanged(int oldValue, int newValue)
        {
            currencyUiValue.text = newValue.ToString();
        }
    }
}