using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Cheking Player is collide or not..
public class EnemyController : MonoBehaviour
{
    //Player Hits By Enemy Some health is Reducing
        private void OnCollisionEnter2D(Collision2D collision2D) {
             
        if(collision2D.gameObject.GetComponent<PlayerController>() != null) {
            PlayerController player = collision2D.gameObject.GetComponent<PlayerController>();
            player.AttackOnPlayer();
            
        }
    }
}
