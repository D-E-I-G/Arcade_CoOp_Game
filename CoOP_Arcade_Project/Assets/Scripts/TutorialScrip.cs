using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScrip : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            SceneManager.LoadScene(0);
        }
    }
}
