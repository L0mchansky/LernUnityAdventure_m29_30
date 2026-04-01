using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace m29_30_task_2._5
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private OrkSettings[] _orkSettings;
        [SerializeField] private ElfSettings[] _elfSettings;
        [SerializeField] private DragonSettings[] _dragonSettings;

        private EnemySpawner _spawner;

        private void Awake()
        {
            _spawner = new EnemySpawner();
        }

        private void Start()
        {
            Spawn(_orkSettings);
            Spawn(_elfSettings);
            Spawn(_dragonSettings);
        }

        private void Spawn(EnemySettings[] settings)
        {
            if (settings.Length == 0)
                throw new ArgumentException($"Переданный массив настроек - пуст: {settings.GetType()}");

            Enemy enemy = _spawner.SpawnEnemy(
                    settings[Random.Range(0, settings.Length)],
                    new Vector3(Random.Range(-15, 15), 0, 0));

            EnemyView enemyView = enemy.GetComponentInChildren<EnemyView>();
            
            if (enemyView != null)
                enemyView.PrintStats();
        }
    }
}