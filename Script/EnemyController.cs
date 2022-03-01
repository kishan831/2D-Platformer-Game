using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D Collision) {
             
        if(Collision.gameObject.GetComponent<Player>() != null) {
            Player player = Collision.gameObject.GetComponent<Player>();
            player.AttackOnPlayer();
            
        }
    }
}
