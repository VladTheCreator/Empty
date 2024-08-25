using UnityEngine;

public class Bounds : MonoBehaviour
{
    private Vector2 halfScreenSize;
    void Start()
    {
        halfScreenSize = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        Debug.Log(halfScreenSize);
    }

    public bool InRightHorizontalBound()
    {
        if (transform.position.x < halfScreenSize.x)
        {
            return true;
        }
        return false;
    }
}
