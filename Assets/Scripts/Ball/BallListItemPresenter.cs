using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BallListItemPresenter : MonoBehaviour
{
    public static void InstantiateListItem(Ball ball, VerticalLayoutGroup ballsList, TMP_Text listItemPrefab)
    {
        TMP_Text newListElement = Instantiate(listItemPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        newListElement.color = ball.color;
        newListElement.transform.SetParent(ballsList.transform);
    }
}
