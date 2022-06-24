using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public bool isPlayer1;
    public bool isPlayer2;
    public bool isPlayer3;
    public bool isPlayer4;
    public ScoreManager manager;


    private void OnTriggerEnter(Collider other)
    {
        //if (other == ball)
        //{
            if (isPlayer1)
            {
                manager.AddPlayer1Score(1);
            }
            else if (isPlayer2)
            {
                manager.AddPlayer2Score(1);
            }
            else if (isPlayer3)
            {
                manager.AddPlayer3Score(1);
            }
            else if (isPlayer4)
            {
                manager.AddPlayer4Score(1);
            }
        //}
    }
}
