using System;
using UnityEngine;

namespace m29_30_task_2._5
{
    public class Dragon : Enemy
    {
        public int Health { get; private set; }
        public int AttackPower { get; private set; }

        public void Initialize(DragonSettings settings)
        {
            if (settings == null)
                throw new ArgumentException("Expected DragonSettings");

            Health = settings.Health;
            AttackPower = settings.AttackPower;
        }
    }
}