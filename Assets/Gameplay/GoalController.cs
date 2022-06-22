using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Ball")
        {
            collision.GetComponent<BallController>().ResetBall();
        }

    }
}
