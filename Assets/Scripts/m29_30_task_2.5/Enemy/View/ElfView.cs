using UnityEngine;

namespace m29_30_task_2._5
{
    public class ElfView : EnemyView
    {
        [SerializeField] Elf _elf;

        public override void PrintStats()
        {
            Debug.Log($"{GetType()} {_elf.Health} {_elf.Agility}");
        }
    }
}