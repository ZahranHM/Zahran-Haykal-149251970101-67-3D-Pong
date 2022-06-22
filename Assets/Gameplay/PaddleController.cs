using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // get input
        Vector3 movement = GetInput();

        // move object 
        MoveObject(movement);

        Vector3 GetInput()
        {
            if (Input.GetKey(leftKey))
            {
                return Vector3.left * speed;
            }
            else if (Input.GetKey(rightKey))
            {
                return Vector3.right * speed;    
            }
            else if (Input.GetKey(upKey))
            {
                return Vector3.forward * speed;
            }
            else if (Input.GetKey(downKey))
            {
                return Vector3.back * speed;
            }
            return Vector3.zero;
        }

        void MoveObject(Vector3 movement)
        {
            if (rig.isKinematic == true)
            {
                transform.Translate(movement * Time.deltaTime); //Is Kinematic active (for the bumper)
            }
            else
            {
                rig.velocity = movement; //Is Kinematic unactive (for the paddle)
            }
        }

    }
}
