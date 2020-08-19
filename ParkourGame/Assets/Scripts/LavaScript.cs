using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy"||other.gameObject.tag == "Player"|| other.gameObject.tag == "Melee")
        {
           Destroy(other.gameObject);//Placeholder
        }
    }
}