using System;

namespace m29_30_task_1
{
    public interface IReadOnlyVariable<T>
    {
        public event Action<T, T> Changed;

        public T Value { get; }
    }
}