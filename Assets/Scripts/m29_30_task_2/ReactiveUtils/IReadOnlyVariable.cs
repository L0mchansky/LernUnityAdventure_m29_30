using System;

namespace m29_30_task_2
{
    public interface IReadOnlyVariable<T>
    {
        public event Action<T, T> Changed;

        public T Value { get; }
    }
}