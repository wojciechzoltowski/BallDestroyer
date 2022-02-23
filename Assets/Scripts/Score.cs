using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TMP_Text amountText;
    public VerticalLayoutGroup ballsList;
    public TMP_Text listElementPrefab;
    private GameObject[] balls;

    // Update is called once per frame
    void FixedUpdate()
    {
        balls = GameObject.FindGameObjectsWithTag("Ball");
        amountText.text = "Balls to destroy: " + balls.Length.ToString();
        UpdateListOfBalls();
    }

    private void UpdateListOfBalls()
    {
        ballsList.transform.DetachChildren();
        foreach (GameObject ball in balls)
        {
            TMP_Text newListElement = Instantiate(listElementPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            newListElement.color = ball.GetComponent<Renderer>().material.color;
            newListElement.transform.SetParent(ballsList.transform);
        }
    }
}
