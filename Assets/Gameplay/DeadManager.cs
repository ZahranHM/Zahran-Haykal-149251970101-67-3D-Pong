using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadManager : MonoBehaviour
{
    public List<GameObject> paddles;
    public List<GameObject> deadwalls;

    public void StopThePlayer(int playerNumber)
    {
        if (playerNumber == 1)
        {
            StopP1(playerNumber);
        }
        else if (playerNumber == 2)
        {
            StopP2(playerNumber);
        }
        else if (playerNumber == 3)
        {
            StopP3(playerNumber);
        }
        else if (playerNumber == 4)
        {
            StopP4(playerNumber);
        }
        else
        {
            Debug.Log("Who's Dead?");
        }
    }

    void StopP1(int num)
    {
        paddles[num - 1].GetComponent<PaddleController>().speed = 0;
        deadwalls[num - 1].transform.position = new Vector3(deadwalls[num-1].transform.position.x, 0, deadwalls[num-1].transform.position.z);
    }
    void StopP2(int num)
    {
        paddles[num - 1].GetComponent<PaddleController>().speed = 0;
        deadwalls[num - 1].transform.position = new Vector3(deadwalls[num - 1].transform.position.x, 0, deadwalls[num - 1].transform.position.z);
    }
    void StopP3(int num)
    {
        paddles[num - 1].GetComponent<PaddleController>().speed = 0;
        deadwalls[num - 1].transform.position = new Vector3(deadwalls[num - 1].transform.position.x, 0, deadwalls[num - 1].transform.position.z);
    }
    void StopP4(int num)
    {
        paddles[num - 1].GetComponent<PaddleController>().speed = 0;
        deadwalls[num - 1].transform.position = new Vector3(deadwalls[num - 1].transform.position.x, 0, deadwalls[num - 1].transform.position.z);
    }
}
