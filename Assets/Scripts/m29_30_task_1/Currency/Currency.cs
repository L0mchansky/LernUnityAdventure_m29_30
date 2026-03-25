using System;

namespace m29_30_task_1
{
    public class Currency : IReadOnlyCurrency
    {
        private CurrencyType _type;
        private ReactiveVariable<int> _amount;

        public Currency(CurrencyType currencyType, int value)
        {
            _amount = new ReactiveVariable<int>(value);
            _type = currencyType;
        }
        public IReadOnlyVariable<int> Amount => _amount;

        public CurrencyType Type => _type;

        public void SetValue(int value)
        {
            _amount.Value = value;
        }
    }
}