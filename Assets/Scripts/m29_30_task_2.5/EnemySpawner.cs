using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace m29_30_task_2._5
{
    public class EnemySpawner
    {
        public Enemy SpawnEnemy(EnemySettings settings, Vector3 position)
        {
            switch (settings)
            {
                case OrkSettings orkSettings:
                    Ork ork = Object.Instantiate(orkSettings.OrkPrefab, position, Quaternion.identity);
                    ork.Initialize(orkSettings);
                    return ork;

                case ElfSettings elfSettings:
                    Elf elf = Object.Instantiate(elfSettings.ElfPrefab, position, Quaternion.identity);
                    elf.Initialize(elfSettings);
                    return elf;

                case DragonSettings dragonSettings:
                    Dragon dragon = Object.Instantiate(dragonSettings.DragonPrefab, position, Quaternion.identity);
                    dragon.Initialize(dragonSettings);
                    return dragon;

                default:
                    throw new ArgumentOutOfRangeException(nameof(settings), settings, null);
            }
        }
    }
}