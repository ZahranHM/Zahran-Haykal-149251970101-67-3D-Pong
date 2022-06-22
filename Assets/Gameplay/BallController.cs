using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    public Vector3 resetPosition;
    private Rigidbody rig;
    public BallManager bmanager;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ResetBall();
        }
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
    }

    public void DestroyBall()
    {
        bmanager.GetComponent<BallManager>().RemoveBall(gameObject);
    }

}
