using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour
{
    float originalHeight = 1;
    public float reducedHeight;


void Update()
{
    Vector3 newScale = new Vector3(transform.localScale.x, originalHeight, transform.localScale.z);

    if (Input.GetKey(KeyCode.LeftControl)) {
        newScale.y = reducedHeight;
    }

    transform.localScale = newScale;
}
}
