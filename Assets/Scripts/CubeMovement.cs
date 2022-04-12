using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public PlayerMove player;
    private Rigidbody2D rb;
    public float speed = 20f;
    private Vector2 direction;
    public AudioClip clip,clip2,clip3;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(4,5);
    }
    void FixedUpdate()
    {
        rb.velocity=direction*speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("left wall"))
        {
            direction = new Vector2(-rb.velocity.x, rb.velocity.y);
            GetComponent<AudioSource>().PlayOneShot(clip2);
        }

        if (collision.CompareTag("right wall"))
        {
            direction = new Vector2(-rb.velocity.x, rb.velocity.y);
            GetComponent<AudioSource>().PlayOneShot(clip2);
        }

        if (collision.CompareTag("up wall"))
        {
            direction = new Vector2(rb.velocity.x, -rb.velocity.y);
            GetComponent<AudioSource>().PlayOneShot(clip2);
        }

        if (collision.CompareTag("Player"))
        {
            direction = new Vector2(rb.velocity.x, -rb.velocity.y);
            GetComponent<AudioSource>().PlayOneShot(clip);
        }

        if (collision.CompareTag("down wall"))
        {
            direction = new Vector2(rb.velocity.x, -rb.velocity.y);
                if (!player.endOfGame) {      
                player.score -= 2; 
            }
            GetComponent<AudioSource>().PlayOneShot(clip3);
        }
    }
}
