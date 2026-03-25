using System;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleDowncast
{
    public class Grid : IReadOnlyGrid
    {
        public event Action<IGridObject> ObjectBinded;

        private Dictionary<Vector2Int, IGridObject> _objects = new();

        public void Bind(IGridObject gridObject, Vector2Int coordinates)
        {
            if (_objects.ContainsKey(coordinates))
            {
                Debug.LogError("Object with coordinates already binded");
                return;
            }

            gridObject.BindTo(new Vector3(coordinates.x, 0, coordinates.y));
            _objects.Add(coordinates, gridObject);
            ObjectBinded?.Invoke(gridObject);
        }
    }
}
