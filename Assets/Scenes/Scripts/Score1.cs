using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    public int scoreP1 = 0;
    public Rigidbody2D ball;
    public Ball ballscript;
    public Text p1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "ball"){
            scoreP1++;
             this.p1.text = scoreP1.ToString();
            Debug.Log(scoreP1);
            ball.position = Vector2.zero;
            ball.velocity = Vector2.zero;
            ballscript.AddStartingForce();

        }
    }
}