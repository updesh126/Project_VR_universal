using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadNextScene(){
    int currentSceneIndex =SceneManager.GetActiveScene().buildIndex;
    SceneManager.LoadScene(currentSceneIndex +1);
   }

   public void LoadStartScene(){
      SceneManager.LoadScene(0);
   }
   public void CarShowRoom(){
      SceneManager.LoadScene(2);
   }
   public void SolarSystem(){
      SceneManager.LoadScene(3);
   }
   public void VideoPlayer(){
      SceneManager.LoadScene(4);
   }
    public void Museum()
    {
        SceneManager.LoadScene(5);
    }
}
