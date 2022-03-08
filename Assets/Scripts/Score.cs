using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TMP_Text amountText;
    public VerticalLayoutGroup ballsList;
    public TMP_Text listItemPrefab;
    private List<Ball> balls;

    private void FixedUpdate()
    {
        balls = BallManager.Instance.allBallsList;
        amountText.text = $"Balls to destroy: {balls.Count}";
        UpdateListOfBalls();
    }

    private void UpdateListOfBalls()
    {
        foreach (Transform ball in ballsList.transform)
        {
            Destroy(ball.gameObject);
        }

        foreach (Ball ball in balls)
        {
            BallListItemPresenter.InstantiateListItem(ball, ballsList, listItemPrefab);
        }
    }
}
