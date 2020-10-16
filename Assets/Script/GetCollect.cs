using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCollect : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
            object p = Cuervos.GetObject();
        }
    }
}
