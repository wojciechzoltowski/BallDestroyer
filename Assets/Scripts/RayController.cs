using UnityEngine;

public class RayController : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                GameObject ball = hit.transform.gameObject;
                BallManager.Instance.DestroyBall(ball);
            }
        }
    }
}
