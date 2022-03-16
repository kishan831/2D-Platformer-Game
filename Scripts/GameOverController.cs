using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    [SerializeField] private Button restart;
    
    public GameObject Heart1,Heart2,Heart3,gameOver;
    public static int health;

    void Start() {
        health = 3;
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    void Update() {
        if(health > 3) {
            health = 3;

           switch(health) {
               case 3:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(true);
                break;

               case 2:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(false);
                break;

               case 1:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(false);
                break;

               case 0:
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;

                break;
           }
        }
    }
    

    private void Awake() {
        restart.onClick.AddListener(ReloadLevel);
        
    }

   void ReloadLevel() {
       Scene scene = SceneManager.GetActiveScene();
      SceneManager.LoadScene(scene.buildIndex);
   }
}
