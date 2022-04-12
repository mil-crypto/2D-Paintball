using UnityEngine;

public class MoveButtons : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector2 direction;
    public float speed = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(6, 5);
    }

    void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("left wall"))
            direction = new Vector2(-rb.velocity.x, rb.velocity.y);

        if (collision.CompareTag("right wall"))
            direction = new Vector2(-rb.velocity.x, rb.velocity.y);

        if (collision.CompareTag("up wall"))
            direction = new Vector2(rb.velocity.x, -rb.velocity.y);

        if (collision.CompareTag("buttom"))
            direction = new Vector2(rb.velocity.x, -rb.velocity.y);

        if (collision.CompareTag("down wall"))
        {
            direction = new Vector2(rb.velocity.x, -rb.velocity.y);
        }
    }
}
