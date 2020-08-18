using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour
{
    CharacterController playerCol;
    float originalHeight;
    public float reducedHeight;


    // Start is called before the first frame update
    void Start()
    {
       playerCol = GetComponent<CharacterController>();
       originalHeight = playerCol.height;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
            Crouch();
        else if(Input.GetKeyUp(KeyCode.LeftControl))
            Reset();
    }

    void Crouch()
    {
        playerCol.height = reducedHeight;
    }

    void Reset()
    {
        playerCol.height = originalHeight;
    }

}
