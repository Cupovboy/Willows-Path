using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public NewBehaviourScript character;



    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        character = GameObject.FindObjectOfType<NewBehaviourScript>();
        if (character.getLookingRight())
        {
            rb.velocity = new Vector2(speed, 0);
          
        }
        else
        {
            rb.velocity = new Vector2(speed*-1, 0);
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(rb.gameObject, .55f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            Destroy(rb.gameObject);
        
    }


}
 