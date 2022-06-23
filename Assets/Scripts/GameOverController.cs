using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public ScoreManager manager;
    public Text winner;

    public void Update()
    {
        if (manager.goal1.isTrigger)
        {
            winner.text = "Player 1 Win";
        }
        else if (manager.goal2.isTrigger)
        {
            winner.text = "Player 2 Win";
        }
        else if (manager.goal3.isTrigger)
        {
            winner.text = "Player 3 Win";
        }
        else
        {
            winner.text = "Player 4 Win";
        }
    }
}
