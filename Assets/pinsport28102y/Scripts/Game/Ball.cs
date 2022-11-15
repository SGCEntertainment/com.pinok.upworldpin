using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D myRigid;

    private void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(transform.localPosition.y < -600 || transform.localPosition.x > 400 || transform.localPosition.x < -400)
        {
            transform.localPosition = new Vector2(0, 600);
            myRigid.velocity = Vector2.zero;
        }
    }
}
