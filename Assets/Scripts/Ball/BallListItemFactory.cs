using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BallListItemFactory
{
    public static void InstantiateListItem(Ball ball, VerticalLayoutGroup ballsList, TMP_Text listItemPrefab)
    {
        TMP_Text newListElement = GameObject.Instantiate(listItemPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        newListElement.color = ball.Color;
        newListElement.transform.SetParent(ballsList.transform);
    }
}
