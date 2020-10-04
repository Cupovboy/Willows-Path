using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Rigidbody rb;  
    public int speed ;
    public int jump;
    public Transform groundCheck;
    private bool LookingRight;
    // private Animator anim;
    public float checkRadius;
    public LayerMask whatIsGround;




    private void Awake()
    {
    	rb = GetComponent<Rigidbody> ();
        LookingRight = true;
        
       // anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {   
        if(Input.GetAxis("Horizontal")!=0)
        transform.Translate(speed*Time.deltaTime,0f,0f);
        lookingDirection();

    }

    void Update ()
    {
    	if (Input.GetButtonDown("Jump") && Physics2D.OverlapCircle
    		(groundCheck.position, checkRadius, whatIsGround))
    	{
           // anim.SetBool("isJumping", true);
            rb.velocity = Vector2.up * jump;
           
        }
        
        if (!Physics2D.OverlapCircle
            (groundCheck.position, checkRadius, whatIsGround))
        {
          //  anim.SetBool("isJumping", false);
        }
        if (Input.GetAxis("Horizontal") != 0)
        if (LookingRight)
        {
            transform.eulerAngles = new UnityEngine.Vector3(0, 0, 0);
        }
        else
        {
            transform.eulerAngles = new UnityEngine.Vector3(0, -180, 0);
        }

  
    }

   

    /* this function set the value of the boolean LookingRight to true if the player is moving on 
     * the right axis and false if he is moving on the left
     */

    void lookingDirection ()
    {

        if (Input.GetAxis("Horizontal") > 0 )
            LookingRight = true;
        if (Input.GetAxis("Horizontal") < 0)
        
            LookingRight = false;
        
    }

    //geter for Looking right
    public bool getLookingRight()
    {
        return LookingRight;
    }

}
