using System;
using UnityEngine;

namespace m29_30_task_2._5
{
    public class Ork : Enemy
    {
        public int Health { get; private set; }
        public int Armor { get; private set; }

        public void Initialize(EnemySettings settings)
        {
            OrkSettings orkSettings = settings as OrkSettings;

            if (orkSettings == null)
                throw new ArgumentException("Expected OrkSettings");

            Health = orkSettings.Health;
            Armor = orkSettings.Armor;
        }
    }
}