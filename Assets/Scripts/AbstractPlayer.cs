using Cinemachine;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public abstract class AbstractPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10;
    public Transform lookAt;
    public CinemachineVirtualCamera cinemachineVirtualCamera;
    private void Start()
    {
        cinemachineVirtualCamera.Follow = lookAt;
    }
    public void Move()
    {
        float verticalDirection =    Input.GetAxis("Vertical");
        float horizontalDirection = Input.GetAxis("Horizontal");
        float frameSpeed = Time.deltaTime * speed;
        transform.Translate(Vector3.forward * frameSpeed * verticalDirection);
        transform.Translate(Vector3.right * frameSpeed * horizontalDirection);
    }
    public void Kill()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif
    }
    public abstract void Fight();// ABSTRACTION
    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetMouseButtonDown(0))
        {
            Fight();
        }
    }
}
