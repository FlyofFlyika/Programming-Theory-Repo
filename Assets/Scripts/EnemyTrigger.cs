using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    List<Enemy> enemies = new List<Enemy>();
    public void AddEnemy(Enemy enemy)// ABSTRACTION
    {
        if (enemies.Contains(enemy)) return;

        enemies.Add(enemy);
    }
    public void RemoveEnemy(Enemy enemy)// ABSTRACTION
    {

        if (!enemies.Contains(enemy)) return;
        enemies.Remove(enemy);
    }
    public Enemy[] GetEnemies()// ABSTRACTION
    {
        return enemies.ToArray();
    }

}
