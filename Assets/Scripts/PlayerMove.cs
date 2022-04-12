using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rb;
    public Text textScore;
    public GameObject textEnd, blue, green, pinq;
    public int score;
    public bool endOfGame;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
        textEnd.SetActive(false);
        blue.SetActive(false);
        green.SetActive(false);
        pinq.SetActive(false);
        endOfGame = false;

    }

    
    void FixedUpdate()
    {
        Score();
        EndGame();
        DifficultyOfTheGame();
    }

    void MoveOnKeyboard()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), rb.velocity.y);
        rb.velocity = direction * speed;
    }
    void DifficultyOfTheGame()
    {
        if (score >= 10)
        {
            blue.SetActive(true);
        }
        if (score >= 20)
        {
            speed *= 2;
            green.SetActive(true);
        }
        if (score >= 30)
        {
            pinq.SetActive(true);
        }
    }
    void Score()
    {
        textScore.text="Score: "+score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.CompareTag("fiveAngles"))&&!endOfGame)
            score++;
        
    }

    void EndGame()
    {
        if (score <= -1)
        {
            endOfGame = true;
            textEnd.SetActive(true);

        }
    }
}
