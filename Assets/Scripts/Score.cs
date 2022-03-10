using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _amountText;
    [SerializeField] private VerticalLayoutGroup _ballsList;
    [SerializeField] private TMP_Text _listItemPrefab;
    private List<Ball> _balls;

    private void FixedUpdate()
    {
        _balls = BallManager.Instance.AllBallsList;
        _amountText.text = $"Balls to destroy: {_balls.Count}";
        UpdateListOfBalls();
    }

    private void UpdateListOfBalls()
    {
        foreach (Transform ball in _ballsList.transform)
        {
            Destroy(ball.gameObject);
        }

        foreach (Ball ball in _balls)
        {
            BallListItemFactory.InstantiateListItem(ball, _ballsList, _listItemPrefab);
        }
    }
}
