using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public Button restart;

    Player player1;
    

    private void Awake() {
        restart.onClick.AddListener(ReloadLevel);
        
    }

    public void PlayerDied() {
        gameObject.SetActive(true);  

   }

   void ReloadLevel() {
      SceneManager.LoadScene(0);
   }
}
