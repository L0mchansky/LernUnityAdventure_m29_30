using UnityEngine;

namespace m29_30_task_2._5
{
    public class OrkView : EnemyView
    {
        [SerializeField] Ork _ork;
        public override void PrintStats()
        {
            Debug.Log($"{GetType()} {_ork.Health} {_ork.Armor}");
        }
    }
}