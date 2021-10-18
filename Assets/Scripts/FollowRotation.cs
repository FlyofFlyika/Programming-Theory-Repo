using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRotation : MonoBehaviour
{
    public Vector2 _look;

    public float rotationPower = 3f;
    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {

        _look = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            transform.rotation *= Quaternion.AngleAxis(_look.x * rotationPower, Vector3.up);
            transform.rotation *= Quaternion.AngleAxis(_look.y * rotationPower, Vector3.left);

            var angles =transform.localEulerAngles;
            angles.z = 0;

            var angle = transform.localEulerAngles.x;
            if (angle > 180 && angle < 340)
            {
                angles.x = 340;
            }
            else if (angle < 180 && angle > 40)
            {
                angles.x = 40;
        }
        transform.localEulerAngles = angles;
        transform.parent.rotation = Quaternion.Euler(0,transform.rotation.eulerAngles.y, 0);
       transform.localEulerAngles = new Vector3(angles.x, 0, 0);
    }
}
