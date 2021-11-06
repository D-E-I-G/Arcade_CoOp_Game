using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            //long game
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            //Tutorial
            SceneManager.LoadScene(2);
        }

        if (Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.Alpha5))
        {
            //short game
            SceneManager.LoadScene(3);
        }
    }
}
