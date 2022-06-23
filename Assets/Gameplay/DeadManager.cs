using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadManager : MonoBehaviour
{
    public List<GameObject> paddles;
    public List<GameObject> goals;
    public List<GameObject> deadwalls;
    public BallManager ballManager;
    private int livingPaddles;
    public GameObject gameOverCanvas;
    private int theWinner;

    void Start()
    {
        livingPaddles = paddles.Count;
    }

    public void StopThePlayer(int playerNumber)
    {
        StopP(playerNumber);
        if (playerNumber > paddles.Count)
        {
            Debug.Log("Who's Dead?");
        }
    }

    void StopP(int num)
    {
        paddles[num - 1].GetComponent<PaddleController>().speed = 0;
        deadwalls[num - 1].transform.position = new Vector3(deadwalls[num - 1].transform.position.x, 0, deadwalls[num - 1].transform.position.z);
        goals[num - 1].SetActive(false) ;
        livingPaddles -= 1;
        IsGameOver();
    }

    void IsGameOver()
    {
        if (livingPaddles == 1)
        {
            Debug.Log("One left...");
            ballManager.maxBallAmount = 0;
            for (int i=0; i < goals.Count; i++)
            {
                goals[i].SetActive(false);
            }
            for (int i = 0; i < paddles.Count; i++)
            {
                if (paddles[i].GetComponent<PaddleController>().speed != 0)
                {
                    theWinner = i + 1;
                }
            }
            gameOverCanvas.SetActive(true);
            gameOverCanvas.GetComponent<GameOverController>().PlayerWinsText.text = "Player " + theWinner.ToString() + " Wins";
        }
    }

}
