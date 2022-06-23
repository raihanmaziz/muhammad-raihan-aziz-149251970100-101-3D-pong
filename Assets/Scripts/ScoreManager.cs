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

    public int maxScore;

    public BallController ball;

    public void AddPlayer1Score(int increment)
    {
        player1Score += increment;
        ball.ResetBall();
        if (player1Score >= maxScore)
        {
            GameOver();
        }
    }

    public void AddPlayer2Score(int increment)
    {
        player2Score += increment;
        ball.ResetBall();
        if (player2Score >= maxScore)
        {
            GameOver();
        }
    }

    public void AddPlayer3Score(int increment)
    {
        player3Score += increment;
        ball.ResetBall();
        if (player3Score >= maxScore)
        {
            GameOver();
        }
    }

    public void AddPlayer4Score(int increment)
    {
        player4Score += increment;
        ball.ResetBall();
        if (player4Score >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
}
