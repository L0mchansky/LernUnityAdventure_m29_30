using System;

namespace m29_30_task_2
{
    public interface IReadOnlyTimer
    {
        bool IsRunning { get; }
        IReadOnlyVariable<float> RemainingTime { get; }
        float FullTime { get; }
    }
}
