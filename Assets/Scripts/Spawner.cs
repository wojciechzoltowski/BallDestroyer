using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float timer = 0.5f;
    private float counter;
    private float xRange = 9f;
    private float zRange = 9f;

    // Start is called before the first frame update
    void Start()
    {
        counter = timer;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBall();
    }

    void SpawnBall()
    {
        float xPosition = Random.Range(0 - xRange, 0 + xRange);
        float zPosition = Random.Range(0 - zRange, 0 + zRange);
        Vector3 spawnPosition = new Vector3(xPosition, 12f, zPosition);

        counter -= Time.deltaTime;

        if (counter <= 0)
        {
            GameObject newBall = Instantiate(prefab, spawnPosition, Quaternion.identity);
            newBall.GetComponent<Renderer>().material.color = Random.ColorHSV();
            counter = timer;
        }
    }
}
