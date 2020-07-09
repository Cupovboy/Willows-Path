using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Rigidbody2D rb;  
    public int speed ;
    public int jump;
    public Transform groundCheck;
    public GameObject FirePrefab;
    public Transform FirePoint;
    private bool LookingRight;
    // private Animator anim;
    public float checkRadius;
    public LayerMask whatIsGround;
    private float shootingTime;
    public float startTime;



    private void Awake()
    {
    	rb = GetComponent<Rigidbody2D> ();
        LookingRight = true;
        shootingTime=0;
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

        if (Input.GetButtonDown("Fire1"))
        {
            
                if (shootingTime <= 0)
                {
                shoot();
                shootingTime = startTime;
                }
                else
                {
                    shootingTime -= Time.deltaTime;
                }
               
            
         }
    }

    // invoke the bullet prefab
    void shoot()
    {
      
            Instantiate(FirePrefab, FirePoint.position, FirePoint.rotation);
      

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
