using System;
using UnityEngine;

namespace m29_30_task_2._5
{
    public class Dragon : Enemy
    {
        private int _health;
        private int _attackPower;

        public override void Initialize(EnemySettings settings)
        {
            DragonSettings dragonSettings = settings as DragonSettings;

            if (dragonSettings == null)
                throw new ArgumentException("Expected DragonSettings");

            _health = dragonSettings.Health;
            _attackPower = dragonSettings.AttackPower;
        }

        public override void PrintStats()
        {
            Debug.Log($"{GetType()} {_health} {_attackPower}");
        }
    }
}
