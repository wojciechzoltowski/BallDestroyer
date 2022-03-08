using System.Collections.Generic;
using UnityEngine;

public sealed class BallManager : MonoBehaviour
{
    [SerializeField] private double _ballSpawnInterval = 0.5;

    private double _counter;
    public List<Ball> allBallsList { get; set; }

    public static BallManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        allBallsList = new List<Ball>();
        _counter = _ballSpawnInterval;
    }

    private void Update()
    {
        if (CanSpawn())
        {
            AddBall();
        }
    }

    private bool CanSpawn()
    {
        _counter -= Time.deltaTime;

        if (_counter <= 0)
        {
            _counter = _ballSpawnInterval;
            return true;
        }

        return false;
    }

    private void AddBall()
    {
        Color color = Random.ColorHSV();
        Ball newBall = new Ball { color = color };
        allBallsList.Add(newBall);
    }
}
