using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ballPrefab;
    private float counter;
    private const float XRange = 9f;
    private const float ZRange = 9f;
    private List<Ball> allBalls;
    private List<Ball> spawnedBalls = new List<Ball>();

    private void Update()
    {
        allBalls = BallManager.Instance.allBallsList;
        List<Ball> ballsToSpawn = allBalls.Except(spawnedBalls).ToList();
        if (ballsToSpawn.Count != 0)
        {
            SpawnBall(ballsToSpawn);
        }
    }

    private void SpawnBall(List<Ball> ballsToSpawn)
    {
        foreach (Ball ball in ballsToSpawn)
        {
            BallPresenter.InstantiateBall(ball, ballPrefab);
            spawnedBalls.Add(ball);
        }
    }
}
