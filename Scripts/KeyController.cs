using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
         private void OnTriggerEnter2D(Collider2D collider2D) {
             
        if(collider2D.gameObject.GetComponent<Player>() != null) {
            Player player = collider2D.gameObject.GetComponent<Player>();
            player.Collectibles();
            Destroy(gameObject);
        }
    }
}
