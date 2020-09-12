using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy"||other.gameObject.tag == "Player"|| other.gameObject.tag == "Melee")
        {
         SceneManager.LoadScene("GameOver");
         Cursor.lockState = CursorLockMode.None; 
        }
    }
}