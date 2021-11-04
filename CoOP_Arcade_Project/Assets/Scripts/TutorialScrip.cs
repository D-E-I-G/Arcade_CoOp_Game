using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScrip : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.Alpha5))
        {
            SceneManager.LoadScene(0);
        }
    }
}
