using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxBallAmount;
    public int spawnInterval;
    public List<GameObject> ballTemplateList;

    private List<GameObject> ballList;
    private float timer;

    private void Start()
    {
        ballList = new List<GameObject>();
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            GenerateBall();
            timer -= spawnInterval;
        }
    }

    public void GenerateBall()
    {
        if (ballList.Count >= maxBallAmount)
        {
            return;
        }

        int randomIndex = Random.Range(0, ballTemplateList.Count);

        GameObject ball = Instantiate(ballTemplateList[randomIndex], ballTemplateList[randomIndex].transform.position, Quaternion.identity, spawnArea);
        ball.SetActive(true);

        ballList.Add(ball);
    }

    public void RemoveBall(GameObject ball)
    {
        ballList.Remove(ball);
        Destroy(ball);
    }
}
