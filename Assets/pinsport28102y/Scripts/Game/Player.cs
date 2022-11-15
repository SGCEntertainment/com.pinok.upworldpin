using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            transform.position = (Vector2)Input.mousePosition;
        }
    }
}
