﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public GameObject player;
    float speed = 4;
    float radius = 5; 

    // Start is called before the first frame update
    void Start()
    { 
   
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform); 
        if(Vector3.Distance(transform.position,player.transform.position)<=radius)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
