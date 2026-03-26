using System.Collections.Generic;
using UnityEngine;

namespace m29_30_task_3
{
    public class Game : MonoBehaviour
    {
        [SerializeField] int _maxSize = 5;
        private Inventory _inventory;

        private void Awake()
        {
            _inventory = new(_maxSize);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Debug.Log("KeyCode.Alpha1 нажат. Добавить 1 Dagger");

                if (_inventory.TryAdd())
                {
                    _inventory.Add(new Item("Dagger"));
                    Debug.Log("Добавлен");
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Debug.Log("KeyCode.Alpha2 нажат. Добавить 1 Sword");

                try
                {
                    _inventory.Add(new Item("Sword"));
                }
                catch (InvenvotryIsFullException)
                {
                    //Action
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Debug.Log("KeyCode.Alpha3 нажат. Получить 2 Dagger");

                try
                {
                    _inventory.TryGetItemsBy("Dagger", 2, out IReadOnlyList<Item> foundItems);
                }
                catch (InventoryItemNotFoundException)
                {
                    //Action
                }
                catch (InventoryInsufficientItemsException)
                {
                    //Action
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                Debug.Log("KeyCode.Alpha4 нажат. Получить 2 Sword");

                try
                {
                    _inventory.TryGetItemsBy("Sword", 2, out IReadOnlyList<Item> foundItems);
                }
                catch (InventoryItemNotFoundException)
                {
                    //Action
                }
                catch (InventoryInsufficientItemsException)
                {
                    //Action
                }
            }
        }
    }
}
