using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShooterWarriorPlayer : AbstractPlayer
{
    public override void Fight()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && hit.transform.CompareTag("Enemy"))
        {
            GetComponent<Enemy>().Kill();
        }
    }
}
