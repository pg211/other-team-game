using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{

    public Animator animator;
    public GameObject enemy;
    public BoxCollider hitbox;
    // Start is called before the first frame update
    void Start()
    {
        hitbox = hitbox.GetComponent<BoxCollider>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();

            
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
        hitbox.size = new Vector3(1, 0.1, 0.1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
