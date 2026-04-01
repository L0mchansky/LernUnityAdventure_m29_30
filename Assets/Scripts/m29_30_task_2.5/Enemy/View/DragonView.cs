using UnityEngine;

namespace m29_30_task_2._5
{
    public class DragonView : EnemyView
    {
        [SerializeField] Dragon _dragon;
        public override void PrintStats()
        {
            Debug.Log($"{GetType()} {_dragon.Health} {_dragon.AttackPower}");
        }
    }
}