using UnityEngine;

public class Player : MonoBehaviour
{
    Transform TopBorder { get; set; }

    private void Start()
    {
        TopBorder = GameObject.Find("TopBorder").transform;
    }

    private void Update()
    {
        if(!gameObject.activeInHierarchy)
        {
            return;
        }

        if(Input.GetMouseButton(0))
        {
            if(Input.mousePosition.y > TopBorder.position.y)
            {
                return;
            }

            transform.position = (Vector2)Input.mousePosition;
        }
    }
}
