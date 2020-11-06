using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{


    void Start()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {

        Destroy(gameObject); 
    }
}
