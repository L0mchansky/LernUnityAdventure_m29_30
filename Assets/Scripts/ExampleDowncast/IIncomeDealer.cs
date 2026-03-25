using System;

namespace ExampleDowncast
{
    public interface IIncomeDealer
    {
        event Action<float> IncomeTrigger;
    }
}
