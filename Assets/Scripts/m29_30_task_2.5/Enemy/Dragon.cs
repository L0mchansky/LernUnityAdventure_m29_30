using System;
using UnityEngine;

namespace m29_30_task_2._5
{
    public class Dragon : Enemy
    {
        public int Health { get; private set; }
        public int AttackPower { get; private set; }

        public override void Initialize(EnemySettings settings)
        {
            DragonSettings dragonSettings = settings as DragonSettings;

            if (dragonSettings == null)
                throw new ArgumentException("Expected DragonSettings");

            Health = dragonSettings.Health;
            AttackPower = dragonSettings.AttackPower;
        }
    }
}