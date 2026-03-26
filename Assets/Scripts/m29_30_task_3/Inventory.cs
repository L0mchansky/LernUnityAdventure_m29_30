using System;
using System.Collections.Generic;
using System.Linq;

namespace m29_30_task_3
{
    public class Inventory
    {
        public int CurrentSize => _items.Count;

        private List<Item> _items = new();

        private int _maxSize;

        public Inventory(int maxSize)
        {
            _maxSize = maxSize;
        }

        public bool TryAdd() => _items.Count == _maxSize;

        public void Add(Item item)
        {
            if (TryAdd())
                throw new InvenvotryIsFullException();

            _items.Add(item);
        }
        public IReadOnlyList<Item> GetAllItems()
        {
            return _items.ToList();
        }

        public void TryGetItemsBy(string name, int count, out IReadOnlyList<Item> foundItems)
        {
            foundItems = null;

            if (string.IsNullOrEmpty(name) || count <= 0)
                throw new ArgumentException($"”казаны не верные входные данные: name: {name}; count: {count}");

            IReadOnlyList<Item> tempFoundItems = _items
                 .Where(item => item.Name == name)
                 .Take(count)
                 .ToList();

            if (tempFoundItems.Count == 0)
                throw new InventoryItemNotFoundException(name);

            if (tempFoundItems.Count < count)
                throw new InventoryInsufficientItemsException(count);

            foreach (Item item in tempFoundItems)
            {
                _items.Remove(item);
            }

            foundItems = tempFoundItems;
        }
    }
}