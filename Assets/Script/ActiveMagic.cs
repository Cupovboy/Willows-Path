using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMagic : MonoBehaviour
{

    private GameObject[] puentes;
    public bool inTrig;
    // Start is called before the first frame update
    void Start()
    {
        if (puentes==null)
            puentes= GameObject.FindGameObjectsWithTag("Puente");
        inTrig = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && inTrig)
        {
            foreach (GameObject puente in puentes)
            {

                puente.transform.position = new Vector3(puente.transform.position.x, -16.62235f, puente.transform.position.z);
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag=="Player")
        {
            inTrig = true;
        }
    }
}
