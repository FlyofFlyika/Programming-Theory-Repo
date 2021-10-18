using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10;
    AbstractPlayer player;
    // Start is called before the first frame update
    private void Start()
    {
        player = FindObjectOfType<AbstractPlayer>();
    }
    public void MoveAi()
    {
       
        float frameSpeed = Time.deltaTime * speed;
        transform.Translate(DirToPlayer() * frameSpeed);
    }
    public Vector3 DirToPlayer()// ABSTRACTION
    {
        return (player.transform.position - transform.position).normalized;
    }
    // Update is called once per frame
    void Update()
    {
        MoveAi();
    }
}
