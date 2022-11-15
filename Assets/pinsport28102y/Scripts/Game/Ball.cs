using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D MyRigid { get; set; }
    AudioSource Source { get; set; }

    private void Start()
    {
        MyRigid = GetComponent<Rigidbody2D>();
        Source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!gameObject.activeInHierarchy)
        {
            MyRigid.velocity = Vector2.zero;
            return;
        }

        if (transform.localPosition.y < -600 || transform.localPosition.x > 400 || transform.localPosition.x < -400)
        {
            transform.localPosition = new Vector2(0, 600);
            MyRigid.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Source.Play();
    }
}
