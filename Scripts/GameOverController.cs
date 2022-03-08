using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public Button restart;
    

    private void Awake() {
        restart.onClick.AddListener(ReloadLevel);
        
    }

    public void PlayerDied() {
        gameObject.SetActive(true);  

   }

   void ReloadLevel() {
       Scene scene = SceneManager.GetActiveScene();
      SceneManager.LoadScene(scene.buildIndex);
   }
}
