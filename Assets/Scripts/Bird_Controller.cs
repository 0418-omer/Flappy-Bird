using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bird_Controller : MonoBehaviour
{
    
   
   public float jumpForce;
   public Rigidbody2D rb;
   private int score;

   public Text scoreText;


    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            rb.velocity = Vector2.up*jumpForce;
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Score")
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
