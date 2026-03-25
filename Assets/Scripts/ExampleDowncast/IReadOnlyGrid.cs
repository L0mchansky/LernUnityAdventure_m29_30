using System;

namespace ExampleDowncast
{
    public interface IReadOnlyGrid
    {
        event Action<IGridObject> ObjectBinded;
    }
}