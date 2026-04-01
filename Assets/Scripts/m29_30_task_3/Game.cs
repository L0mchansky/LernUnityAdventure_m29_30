using System;
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

                if (_inventory.CanAdd())
                {
                    if (_inventory.TryAdd(new Item("Dagger")))
                        Debug.Log("Добавлен");
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Debug.Log("KeyCode.Alpha2 нажат. Добавить 1 Sword");

                if (_inventory.TryAdd(new Item("Sword")))
                    Debug.Log("Добавлен");
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Debug.Log("KeyCode.Alpha3 нажат. Получить 2 Dagger");

                try
                {
                    if (_inventory.TryGetItemsBy("Dagger", 2, out IReadOnlyList<Item> foundItems))
                    {
                        //Action
                    }
                }
                catch (ArgumentException)
                {
                    //Action
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                Debug.Log("KeyCode.Alpha4 нажат. Получить 2 Sword");

                try
                {
                    if (_inventory.TryGetItemsBy("Sword", 2, out IReadOnlyList<Item> foundItems))
                    {
                        //Action
                    }
                }
                catch (ArgumentException)
                {
                    //Action
                }
            }
        }
    }
}
