using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10;
    Rigidbody enemyRigidBody;
    AbstractPlayer player;
    // Start is called before the first frame update
    private void Start()
    {
        player = FindObjectOfType<AbstractPlayer>();
        enemyRigidBody = GetComponent<Rigidbody>();
    }
    public void MoveAi()
    {
       
        float frameSpeed = Time.deltaTime * speed;
        enemyRigidBody.AddForce(DirToPlayer() * frameSpeed,ForceMode.Impulse);
    }
    public Vector3 DirToPlayer()// ABSTRACTION
    {
        return (player.transform.position - transform.position).normalized;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject ==player.gameObject)
        {
            player.Kill();
        }
    }
    // Update is called once per frame
    void Update()
    {
        MoveAi();
    }
}
