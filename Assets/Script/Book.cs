using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Book : MonoBehaviour
{

    public GameObject FirePrefab;
    public Transform book;
    public Transform FirePoint;
    private float shootingTime;
    public float startTime;
    float BookAngle;

    // Start is called before the first frame update
    void Start()
    {
        shootingTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        BookAngle += Input.GetAxis("Mouse Y") *250* -Time.deltaTime;
        BookAngle = Mathf.Clamp(BookAngle, 270,360 );
        book.localRotation = Quaternion.AngleAxis(BookAngle, Vector3.back);
        

        if (Input.GetButtonDown("Fire1"))
        {

            if (shootingTime <= 0)

            {
                Debug.Log(BookAngle);
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
        Vector3 dif = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(dif.y, dif.x) * Mathf.Rad2Deg;
        
        Instantiate(FirePrefab, FirePoint.position, FirePoint.rotation);
      


    }

}    

