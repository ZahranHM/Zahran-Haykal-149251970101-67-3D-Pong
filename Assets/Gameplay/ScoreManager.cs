using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int P1Score;
    public int P2Score;
    public int P3Score;
    public int P4Score;
    public int scoreToBeDead;
    public DeadManager grim;

    public void AddP1Score(int increment)
    {
        P1Score -= increment;
        if (P1Score <= scoreToBeDead)
        {
            YouDead(1);
        }
    }

    public void AddP2Score(int increment)
    {
        P2Score -= increment;
        if (P2Score <= scoreToBeDead)
        {
            YouDead(2);
        }
    }

    public void AddP3Score(int increment)
    {
        P3Score -= increment;
        if (P3Score <= scoreToBeDead)
        {
            YouDead(3);
        }
    }

    public void AddP4Score(int increment)
    {
        P4Score -= increment;
        if (P4Score <= scoreToBeDead)
        {
            YouDead(4);
        }
    }

    public void YouDead(int playerNumber)
    {
        grim.StopThePlayer(playerNumber);
    }

}
