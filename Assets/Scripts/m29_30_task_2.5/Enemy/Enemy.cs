using UnityEngine;

namespace m29_30_task_2._5
{
    public abstract class Enemy : MonoBehaviour
    {
        public abstract void Initialize(EnemySettings enemySettings);
        public abstract void PrintStats();
    }
}
