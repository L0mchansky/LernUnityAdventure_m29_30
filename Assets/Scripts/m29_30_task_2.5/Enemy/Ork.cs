using System;
using UnityEngine;

namespace m29_30_task_2._5
{
    public class Ork : Enemy
    {
        public int Health { get; private set; }
        public int Armor { get; private set; }

        public void Initialize(OrkSettings settings)
        {
            if (settings == null)
                throw new ArgumentException("Expected OrkSettings");

            Health = settings.Health;
            Armor = settings.Armor;
        }
    }
}