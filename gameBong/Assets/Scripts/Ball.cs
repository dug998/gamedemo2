using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    float Score;
    float hightScore;
    public Text Textscore;
    public Text ScoreGame;
    public GameObject gameOver;
    Rigidbody2D myBody;
    // Start is called before the first frame update
    void Start()
    {
        hightScore = PlayerPrefs.GetFloat("Score", 0);
        myBody = GetComponent<Rigidbody2D>();
        ScoreGame.text = PlayerPrefs.GetString("name", "admin");
    }

    // Update is called once per frame
    void Update()
    {
        if (Score > hightScore)
        {
            PlayerPrefs.SetFloat("Score", Score);
            hightScore = Score;
        }
        
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == " brick")
        {
            Score++;
            dertroy a = collision.gameObject.GetComponent<dertroy>();
            a.die();
           ScoreGame.text = PlayerPrefs.GetString("name", "admin") + " hiện có : " + Score+"/ "+ hightScore;
        }


        if (collision.gameObject.tag == "HinhChuNhat")
        {
            myBody.velocity = new Vector2(myBody.velocity.x,4);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "die")
        {
            gameObject.SetActive(false);
            gameOver.SetActive(true);
            Textscore.text = "Score "+Score.ToString();
            
        }
    }
}
