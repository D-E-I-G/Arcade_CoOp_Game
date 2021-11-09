using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreenScript : MonoBehaviour
{
    public Text radiation1;
    public Text radiation2;

    public Text result1;
    public Text result2;

    // Start is called before the first frame update
    void Start()
    {
        radiation1.text = PlayerOneCollision.radNum1.ToString("F0");
        radiation2.text = PlayerTwoCollision.radNum2.ToString("F0");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            //main menu
            SceneManager.LoadScene(0);
        }

        //Player 1 Results
        if (PlayerOneCollision.radNum1 < 3)
        {
            result1.text = ("You have escaped relatively unscathed");
        }
        if (PlayerOneCollision.radNum1 > 2 && PlayerOneCollision.radNum1 < 6)
        {
            result1.text = ("You have a decade or two left");
        }
        if (PlayerOneCollision.radNum1 > 5 && PlayerOneCollision.radNum1 < 9)
        {
            result1.text = ("You've got a couple years");
        }
        if (PlayerOneCollision.radNum1 > 9 && PlayerOneCollision.radNum1 < 13)
        {
            result1.text = ("There's a solid year waiting for you");
        }
        if (PlayerOneCollision.radNum1 > 12 && PlayerOneCollision.radNum1 < 15)
        {
            result1.text = ("You might make it a couple months");
        }
        if (PlayerOneCollision.radNum1 > 14 && PlayerOneCollision.radNum1 < 21)
        {
            result1.text = ("You've got a good few weeks");
        }
        if (PlayerOneCollision.radNum1 > 20)
        {
            result1.text = ("You have a few days to live");
        }

        //Player 2 Results
        if (PlayerTwoCollision.radNum2 < 1)
        {
            result2.text = ("You have escaped unscathed");
        }
        if (PlayerTwoCollision.radNum2 > 0 && PlayerTwoCollision.radNum2 < 3)
        {
            result2.text = ("You have a decade or two left");
        }
        if (PlayerTwoCollision.radNum2 > 2 && PlayerTwoCollision.radNum2 < 6)
        {
            result2.text = ("You've got a couple years");
        }
        if (PlayerTwoCollision.radNum2 > 5 && PlayerTwoCollision.radNum2 < 9)
        {
            result2.text = ("There's a solid year waiting for you");
        }
        if (PlayerTwoCollision.radNum2 > 8 && PlayerTwoCollision.radNum2 < 13)
        {
            result2.text = ("You might make it a couple months");
        }
        if (PlayerTwoCollision.radNum2 > 12 && PlayerTwoCollision.radNum2 < 20)
        {
            result2.text = ("You've got a good few weeks");
        }
        if (PlayerTwoCollision.radNum2 > 19)
        {
            result2.text = ("You have a few days to live");
        }
    }
}
