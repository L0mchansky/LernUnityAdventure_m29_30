using System;
using UnityEngine;

namespace m29_30_task_2._5
{
    [Serializable]
    public class OrkSettings : EnemySettings
    {
        [SerializeField] private Ork _orkPrefab;
        [field: SerializeField] public int Health { get; private set; }
        [field: SerializeField] public int Armor { get; private set; }

        public Ork OrkPrefab => _orkPrefab;
    }
}