using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public ScoreManager manager;
    public bool p1Goal;
    public bool p2Goal;
    public bool p3Goal;
    public bool p4Goal;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Ball")
        {
            if (p1Goal)
            {
                manager.AddP1Score(1);
                collision.GetComponent<BallController>().ResetBall();
            }
            if (p2Goal)
            {
                manager.AddP2Score(1);
                collision.GetComponent<BallController>().ResetBall();
            }
            if (p3Goal)
            {
                manager.AddP3Score(1);
                collision.GetComponent<BallController>().ResetBall();
            }
            if (p4Goal)
            {
                manager.AddP4Score(1);
                collision.GetComponent<BallController>().ResetBall();
            }
        }

    }
}
