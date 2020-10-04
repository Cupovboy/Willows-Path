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
    public GameObject firePoint;


    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        character = GameObject.FindObjectOfType<NewBehaviourScript>();
        firePoint = GameObject.Find("FirePoint");
        Vector3 vector3 = firePoint.transform.right * speed;
        rb.velocity = vector3;

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
 