using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreation : MonoBehaviour
{
    public GameObject PlayerOneP1;
    public GameObject PlayerOneO1;
    public GameObject PlayerOneI1;
    public GameObject PlayerTwoG1;
    public GameObject PlayerTwoR1;
    public GameObject PlayerTwoB1;

    public GameObject PlayerOnePGun;
    public GameObject PlayerOneOGun;
    public GameObject PlayerOneIGun;
    public GameObject PlayerTwoGGun;
    public GameObject PlayerTwoRGun;
    public GameObject PlayerTwoBGun;

    private void Start()
    {
        PlayerOneP1.SetActive(true);
        PlayerOneO1.SetActive(false);
        PlayerOneI1.SetActive(false);
        PlayerTwoG1.SetActive(true);
        PlayerTwoR1.SetActive(false);
        PlayerTwoB1.SetActive(false);

        PlayerOnePGun.SetActive(true);
        PlayerOneOGun.SetActive(false);
        PlayerOneIGun.SetActive(false);
        PlayerTwoGGun.SetActive(true);
        PlayerTwoRGun.SetActive(false);
        PlayerTwoBGun.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //player one selection
        if (Input.GetKeyDown(KeyCode.Z))
        {
            PlayerOneP1.SetActive(true);
            PlayerOneO1.SetActive(false);
            PlayerOneI1.SetActive(false);

            PlayerOnePGun.SetActive(true);
            PlayerOneOGun.SetActive(false);
            PlayerOneIGun.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            PlayerOneP1.SetActive(false);
            PlayerOneO1.SetActive(true);
            PlayerOneI1.SetActive(false);

            PlayerOnePGun.SetActive(false);
            PlayerOneOGun.SetActive(true);
            PlayerOneIGun.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerOneP1.SetActive(false);
            PlayerOneO1.SetActive(false);
            PlayerOneI1.SetActive(true);

            PlayerOnePGun.SetActive(false);
            PlayerOneOGun.SetActive(false);
            PlayerOneIGun.SetActive(true);
        }

        //player two selection
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            PlayerTwoG1.SetActive(true);
            PlayerTwoR1.SetActive(false);
            PlayerTwoB1.SetActive(false);

            PlayerTwoGGun.SetActive(true);
            PlayerTwoRGun.SetActive(false);
            PlayerTwoBGun.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            PlayerTwoG1.SetActive(false);
            PlayerTwoR1.SetActive(true);
            PlayerTwoB1.SetActive(false);

            PlayerTwoGGun.SetActive(false);
            PlayerTwoRGun.SetActive(true);
            PlayerTwoBGun.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            PlayerTwoG1.SetActive(false);
            PlayerTwoR1.SetActive(false);
            PlayerTwoB1.SetActive(true);

            PlayerTwoGGun.SetActive(false);
            PlayerTwoRGun.SetActive(false);
            PlayerTwoBGun.SetActive(true);
        }
    }
}
