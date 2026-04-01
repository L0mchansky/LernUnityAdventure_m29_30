using System;
using UnityEngine;

namespace m29_30_task_2._5
{
    [Serializable]
    public class ElfSettings : EnemySettings
    {
        [SerializeField] private Elf _elfPrefab;
        [field: SerializeField] public int Health { get; private set; }
        [field: SerializeField] public int Agility { get; private set; }

        public Elf ElfPrefab => _elfPrefab;
    }
}