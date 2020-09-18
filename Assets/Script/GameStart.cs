using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Submit")) 
        {
            SceneManager.LoadScene("Play");
        }

        else if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Quit");
        }
    }

}
