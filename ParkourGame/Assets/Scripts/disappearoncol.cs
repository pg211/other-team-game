﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearoncol : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

    }

       void OnTriggerEnter(Collider other) 
 { 
       if(other.gameObject.CompareTag("Ground")||other.gameObject.tag == ("Player")||other.gameObject.tag == ("Lava")||other.gameObject.tag == ("Melee"))
       { 
        Destroy(this.gameObject); 
       } 
 } 
}
