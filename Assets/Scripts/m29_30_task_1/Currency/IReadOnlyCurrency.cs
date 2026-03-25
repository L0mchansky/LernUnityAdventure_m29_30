namespace m29_30_task_1
{
    public interface IReadOnlyCurrency
    {
        public IReadOnlyVariable<int> Amount { get; }
        public CurrencyType Type { get; }
    }
}