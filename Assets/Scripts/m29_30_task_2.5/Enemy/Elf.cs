using System;
using UnityEngine;

namespace m29_30_task_2._5
{
    public class Elf : Enemy
    {
        private int _health;
        private int _agility;

        public override void Initialize(EnemySettings settings)
        {
            ElfSettings elfSettings = settings as ElfSettings;

            if (elfSettings == null)
                throw new ArgumentException("Expected ElfSettings");

            _health = elfSettings.Health;
            _agility = elfSettings.Agility;
        }

        public override void PrintStats()
        {
            Debug.Log($"{GetType()} {_health} {_agility}");
        }
    }
}
