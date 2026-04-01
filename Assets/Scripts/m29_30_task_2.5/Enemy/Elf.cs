using System;
using UnityEngine;

namespace m29_30_task_2._5
{
    public class Elf : Enemy
    {
        public int Health { get; private set; }
        public int Agility { get; private set; }

        public void Initialize(EnemySettings settings)
        {
            ElfSettings elfSettings = settings as ElfSettings;

            if (elfSettings == null)
                throw new ArgumentException("Expected ElfSettings");

            Health = elfSettings.Health;
            Agility = elfSettings.Agility;
        }
    }
}