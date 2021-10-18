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
        transform.Translate(DirToPlayer() * frameSpeed,Space.World);
    }
    public void AddImpulsePlayer(float impulse)
    {

        enemyRigidBody.AddForce(-DirToPlayer()*impulse, ForceMode.Impulse);
    }
    public Vector3 DirToPlayer()// ABSTRACTION
    {
        Vector3 normalDir = (player.transform.position - transform.position).normalized;
        normalDir.y = 0;
        return normalDir;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject ==player.gameObject)
        {
            player.Kill();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        EnemyTrigger enemyTrigger =    other.GetComponent<EnemyTrigger>();
        if (!enemyTrigger)
        {
            Kill();
            return;
        }
        enemyTrigger.AddEnemy(this);
    }
    private void OnTriggerExit(Collider other)
    {
        EnemyTrigger enemyTrigger = other.GetComponent<EnemyTrigger>();
        if (!enemyTrigger) {
            Kill();
            return;
        }
        enemyTrigger.RemoveEnemy(this);
    }

    public void Kill()// ABSTRACTION
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        MoveAi();
    }
}
