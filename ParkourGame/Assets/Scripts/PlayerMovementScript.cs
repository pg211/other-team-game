using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
//   public CharacterController controller;

   public float speed = 12f;
   public float jumpHeight = 3f;
   
   Rigidbody rigid;
   Vector3 velocity;
   bool isGrounded = true;

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

      if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
       {
             rigid.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
                    isGrounded = false;
       }

    }

      void OnCollisionEnter(Collision other)
    {
      if (other.gameObject.tag == "Ground")
      {
        isGrounded = true;
      }
    }
}
    