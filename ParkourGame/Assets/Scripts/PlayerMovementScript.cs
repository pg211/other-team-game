using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    bool isJumping = false;
    public float speed = 16.5f;
    Rigidbody rigid;
    public float jumpforce = 20.4f;
    // Start is called before the first frame update
    void Start()
    {
       rigid = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
           transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
          if(Input.GetKey(KeyCode.A))
        {
           transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
          if(Input.GetKey(KeyCode.S))
        {
           transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
          if(Input.GetKey(KeyCode.D))
        {
           transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
             isJumping = true;
             rigid.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }
}
