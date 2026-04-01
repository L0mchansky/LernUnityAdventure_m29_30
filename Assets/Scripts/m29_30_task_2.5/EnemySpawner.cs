using UnityEngine;

namespace m29_30_task_2._5
{
    public class EnemySpawner
    {
        public Enemy SpawnEnemy(EnemySettings settings, Vector3 position)
        {
            Enemy enemy = UnityEngine.Object.Instantiate(settings.EnemyPrefab, position, Quaternion.identity);
            enemy.Initialize(settings);
            return enemy;
        }
    }
}