using UnityEngine;

public class BallFactory
{
    private const float XRange = 9f;
    private const float ZRange = 9f;

    public static void InstantiateBall(Ball ball, GameObject ballPrefab)
    {
        float xPosition = Random.Range(0 - XRange, 0 + XRange);
        float zPosition = Random.Range(0 - ZRange, 0 + ZRange);
        Vector3 spawnPosition = new Vector3(xPosition, 12f, zPosition);

        GameObject newBall = GameObject.Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
        newBall.GetComponent<Renderer>().material.color = ball.Color;
    }
}
