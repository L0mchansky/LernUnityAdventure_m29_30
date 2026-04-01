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

        public Inventory(int maxSize, List<Item> items)
        {
            _maxSize = maxSize;

            if (items.Count > maxSize)
                throw new ArgumentException($"Указаны не верные входные данные. Кол-во объектов превышает максимальный размер инвентаря: maxSize: {maxSize}; items.Count: {items.Count}");

            _items = items;
        }

        public bool CanAdd() => _items.Count != _maxSize;

        public bool TryAdd(Item item)
        {
            if (CanAdd() == false)
                return false;

            _items.Add(item);

            return true;
        }
        public IReadOnlyList<Item> GetAllItems()
        {
            return _items;
        }

        public bool TryGetItemsBy(string name, int count, out IReadOnlyList<Item> foundItems)
        {
            foundItems = null;

            if (string.IsNullOrEmpty(name) || count <= 0)
                throw new ArgumentException($"Указаны не верные входные данные: name: {name}; count: {count}");

            IReadOnlyList<Item> tempFoundItems = _items
                 .Where(item => item.Name == name)
                 .Take(count)
                 .ToList();

            if (tempFoundItems.Count == 0)
                return false;

            if (tempFoundItems.Count < count)
                return false;

            foreach (Item item in tempFoundItems)
            {
                _items.Remove(item);
            }

            foundItems = tempFoundItems;
            return true;
        }
    }
}