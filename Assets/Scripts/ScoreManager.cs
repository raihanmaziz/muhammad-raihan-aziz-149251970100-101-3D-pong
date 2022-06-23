using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int player1Score;
    public int player2Score;
    public int player3Score;
    public int player4Score;
    public GameObject paddle1;
    public GameObject paddle2;
    public GameObject paddle3;
    public GameObject paddle4;
    public Collider goal1;
    public Collider goal2;
    public Collider goal3;
    public Collider goal4;
    public GameObject gameOver;

    public int maxScore;
    private int endCounter;

    public BallController ball;

    public void Start()
    {
        endCounter = 0;
    }

    public void Update()
    {
        if (endCounter == 3)
        {
            GameOver();
        }
    }

    public void AddPlayer1Score(int increment)
    {
        player1Score += increment;
        ball.ResetBall();
        if (player1Score >= maxScore)
        {
            paddle1.SetActive(false);
            goal1.isTrigger = false;
            endCounter += 1;
        }
    }

    public void AddPlayer2Score(int increment)
    {
        player2Score += increment;
        ball.ResetBall();
        if (player2Score >= maxScore)
        {
            paddle2.SetActive(false);
            goal2.isTrigger = false;
            endCounter += 1;
        }
    }

    public void AddPlayer3Score(int increment)
    {
        player3Score += increment;
        ball.ResetBall();
        if (player3Score >= maxScore)
        {
            paddle3.SetActive(false);
            goal3.isTrigger = false;
            endCounter += 1;
        }
    }

    public void AddPlayer4Score(int increment)
    {
        player4Score += increment;
        ball.ResetBall();
        if (player4Score >= maxScore)
        {
            paddle4.SetActive(false);
            goal4.isTrigger = false;
            endCounter += 1;
        }
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
    }
}
