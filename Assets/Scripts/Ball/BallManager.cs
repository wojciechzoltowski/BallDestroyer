using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public sealed class BallManager : MonoBehaviour
{
    [SerializeField] private double _ballSpawnInterval = 0.5;

    private double _counter;
    public List<Ball> AllBallsList { get; set; }

    public static BallManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError($"Multiple instances of {nameof(BallManager)} detected");
        }
        else
        {
            Instance = this;
        }

        AllBallsList = new List<Ball>();
    }

    private void Start()
    {
        _counter = _ballSpawnInterval;
    }

    private void Update()
    {
        _counter -= Time.deltaTime;
        if (CanSpawn())
        {
            AddBall();
            _counter = _ballSpawnInterval;
        }
    }

    private bool CanSpawn()
    {
        if (_counter <= 0)
        {
            return true;
        }

        return false;
    }

    private void AddBall()
    {
        Ball newBall = new Ball { Color = Random.ColorHSV() };
        AllBallsList.Add(newBall);
    }

    public void DestroyBall(GameObject ball)
    {
        Destroy(ball);
        Color colorOfBallToRemove = ball.GetComponent<Renderer>().material.color;
        Instance.AllBallsList.Remove(Instance.AllBallsList.FirstOrDefault(b => b.Color == colorOfBallToRemove));
    }
}
