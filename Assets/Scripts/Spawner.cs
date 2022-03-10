using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    private List<Ball> _allBalls;
    private readonly List<Ball> _spawnedBalls = new List<Ball>();

    private void Update()
    {
        _allBalls = BallManager.Instance.AllBallsList;
        List<Ball> ballsToSpawn = _allBalls.Except(_spawnedBalls).ToList();
        if (ballsToSpawn.Count != 0)
        {
            SpawnBall(ballsToSpawn);
        }
    }

    private void SpawnBall(List<Ball> ballsToSpawn)
    {
        foreach (Ball ball in ballsToSpawn)
        {
            BallFactory.InstantiateBall(ball, ballPrefab);
            _spawnedBalls.Add(ball);
        }
    }
}
