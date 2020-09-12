using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
  public void EndGame(){
    Debug.Log("Death");
  }
  public void StartGame() {
      SceneManager.LoadScene ("Level1");
  }
  public void QuitGame() {
    Application.Quit ();
  }
}
