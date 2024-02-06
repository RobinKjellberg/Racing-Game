using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInputHandler : MonoBehaviour
{
    public int playerNumber = 1;

    //Components
    TopDownCarController topDownCarController;

    //Awake is called when the script instance is being loaded.
    void Awake()
    {
        topDownCarController = GetComponent<TopDownCarController>();
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

       switch (playerNumber)
            {
                case 1:
                    //Get input from Unity's input system.
                    inputVector.x = Input.GetAxis("Horizontal_P1");
                    inputVector.y = Input.GetAxis("Vertical_P1");
                    break;

                case 2:
                    //Get input from Unity's input system.
                    inputVector.x = Input.GetAxis("Horizontal_P2");
                    inputVector.y = Input.GetAxis("Vertical_P2");
                    break;
            }

        topDownCarController.SetInputVector(inputVector);
    }

}