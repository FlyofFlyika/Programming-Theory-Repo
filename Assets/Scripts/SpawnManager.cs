using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefarb;
    public float time;
    public float repeatRate;
    void Start()
    {
        InvokeRepeating("Spawn", time, repeatRate);
    }
    void Spawn()// ABSTRACTION
    {
       Instantiate<GameObject>(enemyPrefarb, transform.position, enemyPrefarb.transform.rotation);
    }
}
