using System;
using UnityEngine;

namespace m29_30_task_2._5
{
    [Serializable]
    public class DragonSettings : EnemySettings
    {
        [SerializeField] private Dragon _enemyPrefab;
        [field: SerializeField] public int Health { get; private set; }
        [field: SerializeField] public int AttackPower { get; private set; }

        public override Enemy EnemyPrefab => _enemyPrefab;
    }
}