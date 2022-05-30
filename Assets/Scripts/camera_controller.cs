using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    public float RotationSpeed = 1;
    public Transform Target;
    public float offset_player;
    public Transform Player;
    public bool entered = false;

    float mouseX;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (entered == true)
        {
            mouseX += Input.GetAxis("Mouse X") * RotationSpeed;

            transform.LookAt(Target);

            Target.rotation = Quaternion.Euler(Target.rotation.eulerAngles.x, mouseX, 0);

            Player.rotation = Quaternion.Euler(0, mouseX + offset_player, 0);
        }
        
    }
}
