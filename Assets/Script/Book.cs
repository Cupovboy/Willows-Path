using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Book : MonoBehaviour
{

    public GameObject FirePrefab;
    public Transform FirePoint;
    private float shootingTime;
    public float startTime;

    // Start is called before the first frame update
    void Start()
    {
        shootingTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dif = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(dif.y, dif.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ - 90f);


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

        Debug.Log(FirePoint.up *50f);
      


    }

}    

