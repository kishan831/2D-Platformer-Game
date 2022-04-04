using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    [SerializeField] private Button restart;
    
    public int MaxHealth = 3;
    public int CurrentHealth;

    public Animator anim;

    void Start() {
      CurrentHealth = MaxHealth;
    }


    void TakeDamage(int amount) {
        CurrentHealth -= amount;

        if(CurrentHealth <= 0) {
            anim.SetBool("IsDead",true);
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
