using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text P1Score;
    public Text P2Score;
    public Text P3Score;
    public Text P4Score;

    public ScoreManager manager;
    
    void Update()
    {
        P1Score.text = manager.P1Score.ToString();
        P2Score.text = manager.P2Score.ToString();
        P3Score.text = manager.P3Score.ToString();
        P4Score.text = manager.P4Score.ToString();
    }
}
