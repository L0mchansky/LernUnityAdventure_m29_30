using System;
using UnityEngine;

namespace m29_30_task_2._5
{
    public class Ork : Enemy
    {
        private int _health;
        private int _armor;

        public override void Initialize(EnemySettings settings)
        {
            OrkSettings orkSettings = settings as OrkSettings;

            if (orkSettings == null)
                throw new ArgumentException("Expected OrkSettings");

            _health = orkSettings.Health;
            _armor = orkSettings.Armor;
        }

        public override void PrintStats()
        {
            Debug.Log($"{GetType()} {_health} {_armor}");
        }
    }
}
