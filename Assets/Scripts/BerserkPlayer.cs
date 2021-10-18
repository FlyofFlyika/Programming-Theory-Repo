using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerserkPlayer : AbstractPlayer// INHERITANCE
{
    public EnemyTrigger enemyTrigger;
    public float power = 2;
    public override void Fight()// POLYMORPHISM
    {
        foreach(Enemy enemy in enemyTrigger.GetEnemies())
        {
            enemy.AddImpulsePlayer(power);
        }
    }

}
